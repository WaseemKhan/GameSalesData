using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameSalesData.ChartboostDataClasses
{
    public class CBAppInfo
    {
        [JsonProperty(PropertyName = "id")]
        public String ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public String Name { get; set; }

        [JsonProperty(PropertyName = "nickname")]
        public String NickName { get; set; }

        [JsonProperty(PropertyName = "date_created")]
        public String DateCreated { get; set; }

        [JsonProperty(PropertyName = "store_id")]
        public String StoreID { get; set; }

        [JsonProperty(PropertyName = "store_url")]
        public String StoreURL { get; set; }

        [JsonProperty(PropertyName = "bundle_id")]
        public String BundleID { get; set; }

        [JsonProperty(PropertyName = "platform")]
        public String Platform { get; set; }
    };

    public class CBAppsResponse
    {
        [JsonProperty()]
        public CBAppInfo AppInfo { get; set; }
    }

    public class CBAppAnalytics
    {
        [JsonProperty(PropertyName = "date")]
        public String Date { get; set; }

        [JsonProperty(PropertyName = "All Installs")]
        public String AllInstalls { get; set; }

        [JsonProperty(PropertyName = "Bootups")]
        public String Bootups { get; set; }

        [JsonProperty(PropertyName = "Uniques")]
        public String Uniques { get; set; }

        [JsonProperty(PropertyName = "Impressions Delivered")]
        public String ImpressionsDelivered { get; set; }

        [JsonProperty(PropertyName = "Clicks Delivered")]
        public String ClicksDelivered { get; set; }

        [JsonProperty(PropertyName = "Installs Delivered")]
        public String InstallsDelivered { get; set; }

        [JsonProperty(PropertyName = "Impressions Received")]
        public String ImpressionsReceived { get; set; }

        [JsonProperty(PropertyName = "Clicks Received")]
        public String ClicksReceived { get; set; }

        [JsonProperty(PropertyName = "Installs Received")]
        public String InstallsReceived { get; set; }

        [JsonProperty(PropertyName = "Money Earned")]
        public String MoneyEarned { get; set; }

        [JsonProperty(PropertyName = "Money Spent")]
        public String MoneySpent { get; set; }

        [JsonProperty(PropertyName = "eCPM Earned")]
        public String eCPMEarned { get; set; }

        [JsonProperty(PropertyName = "eCPM Spent")]
        public String eCPMSpent { get; set; }

        [JsonProperty(PropertyName = "CTR Delivered")]
        public String CTRDelivered { get; set; }

        [JsonProperty(PropertyName = "CTR Received")]
        public String CTRReceived { get; set; }

        [JsonProperty(PropertyName = "IR Delivered")]
        public String IRDelivered { get; set; }

        [JsonProperty(PropertyName = "IR Received")]
        public String IRReceived { get; set; }

        [JsonProperty(PropertyName = "App ID")]
        public String AppID { get; set; }

        [JsonProperty(PropertyName = "Bundle ID")]
        public String BundleID { get; set; }

        [JsonProperty(PropertyName = "App Name")]
        public String AppName { get; set; }

        [JsonProperty(PropertyName = "App Store ID")]
        public String AppStoreID { get; set; }

        [JsonProperty(PropertyName = "OS")]
        public String OS { get; set; }
    }
}