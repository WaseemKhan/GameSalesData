using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GameSalesData.MobFoxDataClasses
{
    [XmlRoot("response", Namespace="")]
    public class MobFoxPubsResponse
    {
        [XmlAttribute(AttributeName="status")]
        public String Status;

        [XmlElement(ElementName="publication", Namespace="")]
        public List<MobFoxPublication> Publications;
    }

    [Serializable, XmlRootAttribute("publication", Namespace="")]
    public class MobFoxPublication
    {
        [XmlAttribute(AttributeName = "id")]
        public String ID;

        [XmlAttribute(AttributeName = "type")]
        public String AppType;

        [XmlElement(ElementName = "name")]
        public String Name { get; set; }

        [XmlElement(ElementName = "description")]
        public String Description { get; set; }

        [XmlElement(ElementName = "url")]
        public String URL { get; set; }

        [XmlElement(ElementName = "main_channel_id")]
        public String MainChannelID { get; set; }

        [XmlElement(ElementName = "publisher_id")]
        public String PubliserID { get; set; }

        [XmlElement(ElementName = "approval_status")]
        public bool Approved { get; set; }

        [XmlElement(ElementName = "last_request")]
        public String last_request { get; set; }

        [XmlElement(ElementName = "houseads_enabled")]
        public String houseads_enabled { get; set; }

        [XmlElement(ElementName = "ecpmcontrol_approved")]
        public String ecpmcontrol_approved { get; set; }

        [XmlElement(ElementName = "minimum_cpc_enabled")]
        public String minimum_cpc_enabled { get; set; }

        [XmlElement(ElementName = "minimum_cpm_enabled")]
        public String minimum_cpm_enabled { get; set; }

        [XmlElement(ElementName = "min_cpc")]
        public String min_cpc { get; set; }

        [XmlElement(ElementName = "min_cpm")]
        public String min_cpm { get; set; }
    }

    [XmlRoot("response", Namespace="")]
    public class MobFoxStatsResponse
    {
        [XmlAttribute(AttributeName="status")]
        public String Status;

        [XmlElement(ElementName = "report")]
        public MobFoxPubStatsReport Report;
    }


    //
    //
    //
    [Serializable, XmlRootAttribute("report", Namespace = "")]
    public class MobFoxPubStatsReport
    {
        [XmlElement(ElementName = "start_date")]
        public String StartDate;

        [XmlElement(ElementName = "end_date")]
        public String EndDate;

        [XmlElement(ElementName = "type")]
        public String Type;

        [XmlElement(ElementName = "statistics")]
        public MobFoxPubStats Statistics;
    }

    [Serializable, XmlRootAttribute("statistics", Namespace="")]
    public class MobFoxPubStats
    {
        [XmlElement(ElementName = "impressions")]
        public int? Impressions;

        [XmlElement(ElementName = "clicks")]
        public int? Clicks;

        [XmlElement(ElementName = "total_earnings")]
        public MobFoxFinance TotalEarnings;

        [XmlElement(ElementName = "effective_cpm")]
        public MobFoxFinance EffectiveCPM;

        [XmlElement(ElementName = "average_cpc")]
        public MobFoxFinance AverageCPC;

        [XmlElement(ElementName = "click_through_rate")]
        public float? ClickThroughRate { get; set; }
    }

    [Serializable]
    public class MobFoxFinance
    {
        [XmlElement(ElementName = "currency")]
        public String Currency;

        [XmlElement(ElementName = "amount")]
        public float Amount;
    }

    //[Serializable, DataContract(Namespace = "", Name = "response")]
    //public class MobFoxPubsResponse
    //{
    //    public List<MobFoxPublication> Publications;
    //}

    //[Serializable, DataContract(Namespace = "", Name="publication")]
    //public class MobFoxPublication
    //{
    //    //<publication id="15109" type="iphone_app">

    //    [DataMember(Name = "name")]
    //    public String Name {get; set;}

    //    [DataMember(Name = "description")]
    //    public String Description {get; set;}

    //    [DataMember(Name = "url")]
    //    public String URL {get; set;}

    //    [DataMember(Name = "main_channel_id")]
    //    public String MainChannelID {get; set;}

    //    [DataMember(Name = "publisher_id")]
    //    public String PubliserID {get; set;}

    //    [DataMember(Name = "approval_status")]
    //    public String approval_status {get; set;}

    //    [DataMember(Name = "last_request")]
    //    public String last_request {get; set;}

    //    [DataMember(Name = "houseads_enabled")]
    //    public String houseads_enabled {get; set;}

    //    [DataMember(Name = "ecpmcontrol_approved")]
    //    public String ecpmcontrol_approved {get; set;}

    //    [DataMember(Name = "minimum_cpc_enabled")]
    //    public String minimum_cpc_enabled {get; set;}

    //    [DataMember(Name = "minimum_cpm_enabled")]
    //    public String minimum_cpm_enabled {get; set;}

    //    [DataMember(Name = "min_cpc")]
    //    public String min_cpc {get; set;}

    //    [DataMember(Name = "min_cpm")]
    //    public String min_cpm {get; set;}
    //}
}