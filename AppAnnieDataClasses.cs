using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameSalesData.AppAnnieDataClasses
{
    public class AppAnnieAccount
    {
        [JsonProperty(PropertyName = "account_id")]
        public String AccountID { get; set; }

        [JsonProperty(PropertyName = "platform")]
        public String Platform { get; set; }

        [JsonProperty(PropertyName = "account_name")]
        public String AccountName { get; set; }

        [JsonProperty(PropertyName = "publisher_name")]
        public String PublisherName { get; set; }

        [JsonProperty(PropertyName = "first_sales_date")]
        public String FirstSalesDate { get; set; }

        [JsonProperty(PropertyName = "last_sales_date")]
        public String LastSalesDate { get; set; }

        [JsonProperty(PropertyName = "account_status")]
        public String AccountStatus { get; set; }

    }

    public class AppAnnieAccountResponse
    {
        [JsonProperty(PropertyName = "code")]
        public String Code { get; set; }

        [JsonProperty(PropertyName = "account_list")]
        public List<AppAnnieAccount> AccountList { get; set; }

        [JsonProperty(PropertyName = "page_num")]
        public String PageNumber { get; set; }

        [JsonProperty(PropertyName = "page_index")]
        public String PageIndex { get; set; }

        [JsonProperty(PropertyName = "next_page")]
        public String NextPage { get; set; }

        [JsonProperty(PropertyName = "prev_page")]
        public String PrevPage { get; set; }
    }

    public class AppAnnieApplication
    { 
        [JsonProperty(PropertyName = "app_id")]
        public String AppID { get; set; }

        [JsonProperty(PropertyName = "app_name")]
        public String AppName { get; set; }
        
        [JsonProperty(PropertyName = "devices")]
        public String Devices { get; set; }
        	
        [JsonProperty(PropertyName = "icon")]
        public String icon { get; set; }

        [JsonProperty(PropertyName = "status")]
        public String Status { get; set; }

        [JsonProperty(PropertyName = "first_sales_date")]
        public String FirstSalesDate { get; set; }

        [JsonProperty(PropertyName = "last_sales_date")]
        public String LastSalesDate { get; set; }
    }

    public class AppAnnieApplicationResponse
    {
        [JsonProperty(PropertyName = "code")]
        public String Code { get; set; }

        [JsonProperty(PropertyName = "app_list")]
        public List<AppAnnieApplication> AppList;

        [JsonProperty(PropertyName = "page_num")]
        public String PageNumber { get; set; }

        [JsonProperty(PropertyName = "page_index")]
        public String PageIndex { get; set; }

        [JsonProperty(PropertyName = "next_page")]
        public String NextPage { get; set; }

        [JsonProperty(PropertyName = "prev_page")]
        public String PrevPage { get; set; }
    }
}
