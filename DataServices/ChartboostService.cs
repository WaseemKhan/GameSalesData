﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

using GameSalesData.Database;
using GameSalesData.Database.GameSalesDataMSSQLDataSetTableAdapters;
using GameSalesData.ChartboostDataClasses;

namespace GameSalesData.DataServices
{
    class ChartboostService
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = null;
        List<CBAppInfo> CBAppList = new List<CBAppInfo>();

        String userID = "50c9ba2217ba47942f00002b";
        String userSig = "04fe0e8941554d6a9ca664c7916f5d1ebd3189d2";

        public ChartboostService()
        {
            client.BaseAddress = new Uri("http://api.chartboost.com/");
        }

        public bool GetChartboostApps()
        {
            bool bReturn = false;

            String userString = "user_id=" + userID + "&user_signature=" + userSig;

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                response = client.GetAsync("/apps/?" + userString).Result;

                if (response.IsSuccessStatusCode)
                {
                    var CBApps = response.Content.ReadAsAsync<Dictionary<string, CBAppInfo>>().Result;

                    CBAppList.Clear();

                    foreach (var CBApp in CBApps)
                    {
                        CBAppList.Add(CBApp.Value);
                    }

                    bReturn = true;
                }
            }
            catch(Exception ex)
            {
            }

            return bReturn;
        }


        public bool UpdateAppsInDB(Database.GameSalesDataDataSet.ChartboostAppsDataTable CBTable)
        {
            if (GetChartboostApps())
            {
                Database.GameSalesDataDataSetTableAdapters.ChartboostAppsTableAdapter CBTableAdapter = 
                                                new Database.GameSalesDataDataSetTableAdapters.ChartboostAppsTableAdapter();

                foreach (var CBApp in CBAppList)
                {
                    GameSalesDataDataSet.ChartboostAppsRow DBRow = CBTable.FindByID(CBApp.ID);

                    if (DBRow == null)
                    {
                        CBTable.AddChartboostAppsRow(CBApp.ID, CBApp.Name, CBApp.Platform,"");
                    }
                    else
                    {
                        DBRow.ApplicationName = CBApp.Name;
                        DBRow.Platform = CBApp.Platform;
                    }
                }

                return true;
            }
            else
                return false;
        }
    }
}
