using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using GameSalesData.AdMobDataClasses;

using GameSalesData.Database;

namespace GameSalesData.DataServices
{
    class AdmobService
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = null;
        List<AdMobSiteData> AdmobAppList = new List<AdMobSiteData>();

        String Email = "zaftab@gmail.com";
        String Password = "g1ngn8v8d9y54b8c";
        String ClientKey = "k19d3456b72ef4b8065bf4ca4f2ae208";
        String SessionToken = "";

        List<KeyValuePair<string, string>> ParamPair;

        public AdmobService()
        {
            client.BaseAddress = new Uri("https://api.admob.com/");

            ParamPair = new List<KeyValuePair<string, string>>
                                        {
                                            new KeyValuePair<string, string>("client_key", ClientKey),
                                            new KeyValuePair<string, string>("email", Email),
                                            new KeyValuePair<string, string>("password", Password)
                                        };
        }


        public bool Authenticate()
        {
            bool breturn = false;

            AdMobLoginResponse AdMobLoginResp;

            response = client.PostAsync("v2/auth/login", new FormUrlEncodedContent(ParamPair)).Result;

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                AdMobLoginResp = response.Content.ReadAsAsync<AdMobLoginResponse>().Result;

                if (AdMobLoginResp.Errors.Length > 1)
                {
                }
                else
                {
                    SessionToken = AdMobLoginResp.Data.Token;
                }

                breturn = true;
            }

            return breturn;
        }

        public bool GetAdmobApps()
        {
            AdMobSiteSearchResponse AdMoSiteSearchResp;
            bool breturn = false;

            if (SessionToken == "")
                Authenticate();

            if (SessionToken != "")
            {
                response = client.GetAsync("v2/site/search?client_key=" + ClientKey + "&token=" + SessionToken).Result;

                if (response.IsSuccessStatusCode)
                {
                    AdMoSiteSearchResp = response.Content.ReadAsAsync<AdMobSiteSearchResponse>().Result;

                    if (AdMoSiteSearchResp.Errors.Length > 1)
                    {
                    }
                    else
                    {
                        AdmobAppList.AddRange(AdMoSiteSearchResp.Data);

                        breturn = true;
                    }
                }
            }

            return breturn;
        }

        public bool UpdateAppsInDB(Database.GameSalesDataDataSet.AdMobAppsDataTable AMTable)
        {
            bool breturn = false;

            if (GetAdmobApps())
            {
                foreach (var AdmobApp in AdmobAppList)
                {
                    GameSalesDataDataSet.AdMobAppsRow DBRow = AMTable.FindByID(AdmobApp.ID);

                    if (DBRow == null)
                    {
                        AMTable.AddAdMobAppsRow(AdmobApp.ID, AdmobApp.Name);
                    }
                    else
                    {
                        DBRow.ApplicationName = AdmobApp.Name;
                    }

                    breturn = true;
                }
            }

            return breturn;
        }
    }
}
