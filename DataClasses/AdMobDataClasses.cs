using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameSalesData.AdMobDataClasses
{
    public class AdMobResponseError
    {
        [JsonProperty(PropertyName = "code")]
        public String Code;

        [JsonProperty(PropertyName = "msg")]
        public String Message;
    }

    public class AdMobResponsePage
    {
        [JsonProperty(PropertyName = "current")]
        public int Current;

        [JsonProperty(PropertyName = "total")]
        public int Total;
    }

    public class AdMobLoginResponse
    {
        [JsonProperty(PropertyName = "errors")]
        public AdMobResponseError[] Errors { get; set; }

        [JsonProperty(PropertyName = "warnings")]
        public AdMobResponseError[] Warnings { get; set; }

        [JsonProperty(PropertyName = "data")]
        public AdMobLoginData Data { get; set; }

        [JsonProperty(PropertyName = "page")]
        public AdMobResponsePage Page { get; set; }
    }

    public class AdMobLoginData 
    {
        [JsonProperty(PropertyName = "token")]
        public String Token;
    }

    public class AdMobSiteSearchResponse
    {
        [JsonProperty(PropertyName = "errors")]
        public AdMobResponseError[] Errors { get; set; }

        [JsonProperty(PropertyName = "warnings")]
        public AdMobResponseError[] Warnings { get; set; }

        [JsonProperty(PropertyName = "data")]
        public AdMobSiteData[] Data { get; set; }

        [JsonProperty(PropertyName = "page")]
        public AdMobResponsePage Page { get; set; }
    }

    public class AdMobSiteData 
    {
        [JsonProperty(PropertyName = "id")]
        public String ID;

        [JsonProperty(PropertyName = "name")]
        public String Name;

        [JsonProperty(PropertyName = "url")]
        public String URL;

        [JsonProperty(PropertyName = "description")]
        public String Description;
    }
}