using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GameSalesData.AdMobDataClasses
{
    public class AdMobResponse
    {
        [JsonProperty(PropertyName = "errors")]
        public String Errors { get; set; }

        [JsonProperty(PropertyName = "warnings")]
        public String Warnings { get; set; }

        [JsonProperty(PropertyName = "data")]
        public String Data { get; set; }

        [JsonProperty(PropertyName = "page")]
        public String Page { get; set; }
    }

    [JsonObject()]
    public class AdMobLoginParams
    {
        [JsonProperty(PropertyName = "email")]
        public String email { get; set; }

        [JsonProperty(PropertyName = "password")]
        public String password { get; set; }

        [JsonProperty(PropertyName = "client_key")]
        public String client_key { get; set; }
    }
}