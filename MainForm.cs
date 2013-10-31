using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using Binbin.AdMobApi;

namespace GameSalesData
{
    public partial class MainForm : Form
    {
        public List<AppAnnieDataClasses.AppAnnieAccount> AppAnnieAccounts = new List<AppAnnieDataClasses.AppAnnieAccount>();
        public List<AppAnnieDataClasses.AppAnnieApplication> AppAnnieApps = new List<AppAnnieDataClasses.AppAnnieApplication>();

        public List<MobFoxDataClasses.MobFoxPublication> MobFoxPubs = new List<MobFoxDataClasses.MobFoxPublication>();

        public AdMobDataClasses.AdMobLoginResponse AdMobLoginResp;

        public MainForm()
        {
            InitializeComponent();

            dtpStartDate.Value = DateTime.Today; //DateTime.Today.AddDays(1 - DateTime.Today.Day);
            dtpEndDate.Value = DateTime.Today;
        }

        private void btnCBRefresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (tabControl1.SelectedIndex == 0)
            {
                grdChartBoost.Columns.Clear();
                grdChartBoost.Rows.Clear();

                grdChartBoost.Columns.Add("Column0", "Applications");
                grdChartBoost.Columns[0].Frozen = true;

                grdChartBoost.Columns.Add("Column1", "Totals");
                grdChartBoost.Columns[1].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                grdChartBoost.Columns[1].Frozen = true;

                FillGridCBApps(dtpStartDate.Value, dtpEndDate.Value);
                PerformCBGridTotals();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                grdMobFox.Columns.Clear();
                grdMobFox.Rows.Clear();

                grdMobFox.Columns.Add("Column0", "Applications");
                grdMobFox.Columns[0].Frozen = true;

                grdMobFox.Columns.Add("Column1", "Totals");
                grdMobFox.Columns[1].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                grdMobFox.Columns[1].Frozen = true;

                FillGridMobFoxApps(dtpStartDate.Value, dtpEndDate.Value);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                grdAppAnnie.Columns.Clear();
                grdAppAnnie.Rows.Clear();

                grdAppAnnie.Columns.Add("Column0", "Applications");
                grdAppAnnie.Columns[0].Frozen = true;

                grdAppAnnie.Columns.Add("Column1", "Totals");
                grdAppAnnie.Columns[1].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                grdAppAnnie.Columns[1].Frozen = true;

                FillGridAppAnnieApps(dtpStartDate.Value, dtpEndDate.Value);
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                grdAdMob.Columns.Clear();
                grdAdMob.Rows.Clear();

                grdAdMob.Columns.Add("Column0", "Applications");
                grdAdMob.Columns[0].Frozen = true;

                grdAdMob.Columns.Add("Column1", "Totals");
                grdAdMob.Columns[1].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                grdAdMob.Columns[1].Frozen = true;

                FillGridAdMobApps(dtpStartDate.Value, dtpEndDate.Value);
            }
            Cursor = Cursors.Default;
        }

        private void FillGridAdMobApps(DateTime StartDate, DateTime EndDate)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = null;

            // Populate Date in Header
            for (DateTime dt = StartDate; dt <= EndDate; dt = dt.AddDays(1))
            {
                int ColumnIndex = grdAdMob.Columns.Add("Column" + grdMobFox.Columns.Count, dt.ToString("yyyy-MM-dd"));
                grdAdMob.Columns[ColumnIndex].Tag = dt.ToString("yyyy-MM-dd");
            }

            String email = "zaftab@gmail.com";
            String password = "g1ngn8v8d9y54b8c";
            String clientKey = "k19d3456b72ef4b8065bf4ca4f2ae208";

            client.BaseAddress = new Uri("https://api.admob.com/");

            List<KeyValuePair<string,string>> ParamPair = new List<KeyValuePair<string, string>>
                                                            {
                                                                new KeyValuePair<string, string>("client_key", clientKey),
                                                                new KeyValuePair<string, string>("email", email),
                                                                new KeyValuePair<string, string>("password", password)
                                                            };

            response = client.PostAsync("v2/auth/login", new FormUrlEncodedContent(ParamPair)).Result;

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                AdMobLoginResp = response.Content.ReadAsAsync<AdMobDataClasses.AdMobLoginResponse>().Result;

                if (AdMobLoginResp.Errors.Length > 1)
                {
                }
                else
                {
                    ParamPair = new List<KeyValuePair<string, string>>
                                                {
                                                    new KeyValuePair<string, string>("client_key", clientKey),
                                                    new KeyValuePair<string, string>("token", AdMobLoginResp.Data.Token)
                                                };

                    response = client.GetAsync("v2/site/search?client_key=" + clientKey + "&token=" + AdMobLoginResp.Data.Token).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        AdMobDataClasses.AdMobSiteSearchResponse AdMoSiteSearchResp = response.Content.ReadAsAsync<AdMobDataClasses.AdMobSiteSearchResponse>().Result;

                        if (AdMoSiteSearchResp.Errors.Length > 1)
                        {
                        }
                        else
                        {
                            foreach (var AdMobSite in AdMoSiteSearchResp.Data)
                            {
                                int rowIndex = grdAdMob.Rows.Add();

                                grdAdMob.Rows[rowIndex].Cells[0].Value = AdMobSite.Name;

                                // Initialize row columns with Zero
                                for (int colIndex = 2; colIndex <= grdMobFox.ColumnCount - 1; colIndex++)
                                    grdAdMob.Rows[rowIndex].Cells[colIndex].Value = "$0.0";
                            }
                        }
                    }
                }
            }
        }

        private void FillGridMobFoxApps(DateTime StartDate, DateTime EndDate)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = null;

            // Populate Date in Header
            for (DateTime dt = StartDate; dt <= EndDate; dt = dt.AddDays(1))
            {
                int ColumnIndex = grdMobFox.Columns.Add("Column" + grdMobFox.Columns.Count, dt.ToString("yyyy-MM-dd"));
                grdMobFox.Columns[ColumnIndex].Tag = dt.ToString("yyyy-MM-dd");
            }

            String actID = "18810";
            String apiKey = "f8600d0224cf3d5e677f1f340a5e992c";

            String userString = actID + "/" + apiKey;

            client.BaseAddress = new Uri("http://api.mobfox.com/");

            // Add an Accept header for XML format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

            response = client.GetAsync("/api/" + userString  + "/listPublications").Result;

            if (response.IsSuccessStatusCode)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(MobFoxDataClasses.MobFoxPubsResponse));

                MobFoxDataClasses.MobFoxPubsResponse MFResponse = null;

                MFResponse = (MobFoxDataClasses.MobFoxPubsResponse)serializer.Deserialize(response.Content.ReadAsStreamAsync().Result);

                if (MFResponse.Status == "success")
                {
                    MobFoxPubs = MFResponse.Publications;

                    foreach (var MFPublication in MobFoxPubs)
                    {
                        if (MFPublication.Approved)
                        {
                            int rowIndex = grdMobFox.Rows.Add();

                            grdMobFox.Rows[rowIndex].Cells[0].Value = MFPublication.Name;

                            // Initialize row columns with Zero
                            for (int colIndex = 2; colIndex <= grdMobFox.ColumnCount - 1; colIndex++)
                                grdMobFox.Rows[rowIndex].Cells[colIndex].Value = "$0.0";

                            FillMFAppRevenue(StartDate, EndDate, MFPublication.ID, rowIndex, userString);
                        }
                    }
                }
            }
        }

        private void FillMFAppRevenue(DateTime StartDate, DateTime EndDate, String MFAppID, int rowIndex, String userString)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = null;

            client.BaseAddress = new Uri("http://api.mobfox.com/");


            for (DateTime queryDate = StartDate; queryDate <= EndDate; queryDate = queryDate.AddDays(1))
            {
                String queryString = "/api/" + userString + "/generatePublisherReport&start_date=" + queryDate.ToString("yyyy-MM-dd") + "&end_date=" +
                                        queryDate.ToString("yyyy-MM-dd") + "&publication_id=" + MFAppID;

                response = client.GetAsync(queryString).Result;

                if (response.IsSuccessStatusCode)
                {
                    var MFAppAnalytics = response.Content.ReadAsStringAsync().Result;

                    XmlSerializer serializer = new XmlSerializer(typeof(MobFoxDataClasses.MobFoxStatsResponse));

                    MobFoxDataClasses.MobFoxStatsResponse MFResponse = null;

                    String strResponse = response.Content.ReadAsStringAsync().Result;

                    MFResponse = (MobFoxDataClasses.MobFoxStatsResponse)serializer.Deserialize(response.Content.ReadAsStreamAsync().Result);

                    if (MFResponse.Status == "success")
                    {
                        for (int colIndex = 2; colIndex < grdMobFox.Columns.Count; colIndex++)
                        {
                            if (grdMobFox.Columns[colIndex].Tag.ToString() == MFResponse.Report.StartDate)
                            {
                                //grdMobFox.Rows[rowIndex].Cells[colIndex].Value = MFResponse.Report.Statistics.TotalEarnings.Amount;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void FillGridCBApps(DateTime StartDate, DateTime EndDate)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = null;

            // Populate Date in Header
            for (DateTime dt = StartDate; dt <= EndDate; dt = dt.AddDays(1))
            {
                int ColumnIndex = grdChartBoost.Columns.Add("Column" + grdChartBoost.Columns.Count, dt.ToString("yyyy-MM-dd"));
                grdChartBoost.Columns[ColumnIndex].Tag = dt.ToString("yyyy-MM-dd");
            }

            String userID = "50c9ba2217ba47942f00002b";
            String userSig = "04fe0e8941554d6a9ca664c7916f5d1ebd3189d2";
            String userString = "user_id=" + userID + "&user_signature=" + userSig;
            client.BaseAddress = new Uri("http://api.chartboost.com/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            response = client.GetAsync("/apps/?" + userString).Result;

            if (response.IsSuccessStatusCode)
            {
                var CBApps = response.Content.ReadAsAsync<Dictionary<string, ChartboostDataClasses.CBAppInfo>>().Result;

                List<ChartboostDataClasses.CBAppInfo> CBAppList = new List<ChartboostDataClasses.CBAppInfo>();

                grdChartBoost.Rows.Add(CBApps.Count-1);

                // Initialize row columns with Zero
                for (int rowIndex = 0; rowIndex <= grdChartBoost.RowCount -1; rowIndex++)
                    for (int colIndex = 2; colIndex <= grdChartBoost.ColumnCount - 1; colIndex++)
                        grdChartBoost.Rows[rowIndex].Cells[colIndex].Value = "$0.0";

                int rIndex = 0;

                foreach (var CBApp in CBApps)
                {
                    CBAppList.Add(CBApp.Value);

                    grdChartBoost.Rows[rIndex].Cells[0].Value = CBApp.Value.Name;

                    FillAppRevenues(StartDate, EndDate, CBApp.Value.ID, rIndex, userString);

                    rIndex++;
                }
            }
        }

        private void FillAppRevenues(DateTime StartDate, DateTime EndDate, String CBAppID, int rowIndex, String userString)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = null;

            client.BaseAddress = new Uri("http://api.chartboost.com/");

            String queryString = "app_ids=" + CBAppID + "&date_min=" + StartDate.ToString("yyyy-MM-dd") + "&date_max=" +
                                    EndDate.ToString("yyyy-MM-dd");

            response = client.GetAsync("/analytics/apps?" + queryString + "&" + userString).Result;

            if (response.IsSuccessStatusCode)
            {
                var CBAppAnalytics = response.Content.ReadAsAsync<ChartboostDataClasses.CBAppAnalytics[]>().Result;

                grdChartBoost.Rows[rowIndex].Cells[0].Tag = CBAppAnalytics;

                foreach (var CBAnalytic in CBAppAnalytics)
                {
                    ChartboostDataClasses.CBAppAnalytics CBAnaly = (ChartboostDataClasses.CBAppAnalytics)CBAnalytic;

                    for (int colIndex = 2; colIndex < grdChartBoost.Columns.Count; colIndex++)
                    {
                        if (grdChartBoost.Columns[colIndex].Tag.ToString() == CBAnaly.Date)
                        {
                            grdChartBoost.Rows[rowIndex].Cells[colIndex].Value = CBAnaly.MoneyEarned;
                            break;
                        }
                    }
                }
            }
        }

        private void PerformCBGridTotals()
        {
            for (int rowIndex = 0; rowIndex < grdChartBoost.RowCount; rowIndex++)
            {
                decimal rowTotal = 0;

                for (int colIndex = 2; colIndex < grdChartBoost.ColumnCount; colIndex++)
                {
                    String cellValue = (String)grdChartBoost.Rows[rowIndex].Cells[colIndex].Value;

                    if (!string.IsNullOrEmpty(cellValue))
                        rowTotal += decimal.Parse(cellValue.Substring(1));
                }

                grdChartBoost.Rows[rowIndex].Cells[1].Value = rowTotal;
            }
        }

        private void grdChartBoost_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = (DataGridViewCell)grdChartBoost.Rows[e.RowIndex].Cells[e.ColumnIndex];

            DataPopupForm frm = new DataPopupForm();

            ChartboostDataClasses.CBAppAnalytics[] Analy = (ChartboostDataClasses.CBAppAnalytics[])cell.Tag;

            frm.SetData(cell.Value.ToString());

            frm.ShowDialog();
        }

        private void FillGridAppAnnieApps(DateTime StartDate, DateTime EndDate)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = null;

            // Populate Date in Header
            for (DateTime dt = StartDate; dt <= EndDate; dt = dt.AddDays(1))
            {
                int ColumnIndex = grdAppAnnie.Columns.Add("Column" + grdChartBoost.Columns.Count, dt.ToString("yyyy-MM-dd"));
                grdAppAnnie.Columns[ColumnIndex].Tag = dt.ToString("yyyy-MM-dd");
            }

            client.BaseAddress = new Uri("https://api.appannie.com/");

            String usrPwd = "waseem.khan@tenpearls.com:kilmar@73";

            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(usrPwd);
            String encUsrPwd = System.Convert.ToBase64String(toEncodeAsBytes);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encUsrPwd);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            response = client.GetAsync("/v1/accounts?page_index=0").Result;

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var products = response.Content.ReadAsAsync<AppAnnieDataClasses.AppAnnieAccountResponse>().Result;

                AppAnnieAccounts = products.AccountList;

                foreach (AppAnnieDataClasses.AppAnnieAccount Act in AppAnnieAccounts)
                {
                    response = client.GetAsync("/v1/accounts/" + Act.AccountID + "/apps?page_index=0").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        String resp = response.Content.ReadAsStringAsync().Result;

                        // Parse the response body. Blocking!
                        var annApps = response.Content.ReadAsAsync<AppAnnieDataClasses.AppAnnieApplicationResponse>().Result;

                        foreach (var AppAnnieApp in annApps.AppList)
                        {
                            int rowIndex = grdAppAnnie.Rows.Add(1);

                            // Initialize row columns with Zero
                            for (int colIndex = 2; colIndex <= grdAppAnnie.ColumnCount - 1; colIndex++)
                                grdAppAnnie.Rows[rowIndex].Cells[colIndex].Value = "$0.0";

                            grdAppAnnie.Rows[rowIndex].Cells[0].Value = AppAnnieApp.AppName;

                            FillAppAnnieAppRevenues(StartDate, EndDate, Act.AccountID, AppAnnieApp.AppID, rowIndex);
                        }

                        AppAnnieApps.AddRange(annApps.AppList);
                    }
                }
            }
        }

        private void FillAppAnnieAppRevenues(DateTime StartDate, DateTime EndDate, String AccountID, String AppID, int rowIndex)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = null;

            client.BaseAddress = new Uri("https://api.appannie.com/");

            String usrPwd = "waseem.khan@tenpearls.com:kilmar@73";

            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(usrPwd);
            String encUsrPwd = System.Convert.ToBase64String(toEncodeAsBytes);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encUsrPwd);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            String queryString = AccountID + "/apps/" + AppID + "/sales?breakdown=date+iap" + "&start_date=" + StartDate.ToString("yyyy-MM-dd") + "&end_date=" +
                                 EndDate.ToString("yyyy-MM-dd");

            response = client.GetAsync("/v1/accounts/" + queryString ).Result;

            //api.appannie.com /v1/accounts/1000/apps/com.superfungame/sales?break_down=date+iap
            //                                                                                &start_date=2012-01-01
            //                                                                                &end_date=2012-02-01

            if (response.IsSuccessStatusCode)
            {
                String resp = response.Content.ReadAsStringAsync().Result;

                //var CBAppAnalytics = response.Content.ReadAsAsync<ChartboostDataClasses.CBAppAnalytics[]>().Result;

                //grdChartBoost.Rows[rowIndex].Cells[0].Tag = CBAppAnalytics;

                //foreach (var CBAnalytic in CBAppAnalytics)
                //{
                //    ChartboostDataClasses.CBAppAnalytics CBAnaly = (ChartboostDataClasses.CBAppAnalytics)CBAnalytic;

                //    for (int colIndex = 2; colIndex < grdChartBoost.Columns.Count; colIndex++)
                //    {
                //        if (grdChartBoost.Columns[colIndex].Tag.ToString() == CBAnaly.Date)
                //        {
                //            grdChartBoost.Rows[rowIndex].Cells[colIndex].Value = CBAnaly.MoneyEarned;
                //            break;
                //        }
                //    }
                //}
            }
        }

        private void btnAdMobLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRevMob_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = null;

            client.BaseAddress = new Uri("https://console.revmobmobileadnetwork.com/");

            String usrPwd = "contact@gameplan8.com:karachi1";

            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(usrPwd);
            String encUsrPwd = System.Convert.ToBase64String(toEncodeAsBytes);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encUsrPwd);

            // Add an Accept header for JSON format.
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

            response = client.GetAsync("/publishers/reports").Result;

            if (response.IsSuccessStatusCode)
            {
                String resp = response.Content.ReadAsStringAsync().Result;
            }
        }

    } // Class End
} // Namespace End
