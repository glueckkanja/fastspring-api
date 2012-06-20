using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    [XmlRoot("order"), Serializable]
    public class Order : FastSpringObject
    {
        [XmlElement("reference")]
        public string Reference { get; set; }

        [XmlElement("test")]
        public bool IsTest { get; set; }

        [XmlElement("status")]
        public OrderStatus Status { get; set; }

        [XmlElement("statusChanged")]
        public DateTime StatusChanged { get; set; }

        [XmlElement("due")]
        public DateTime? Due { get; set; }

        [XmlElement("currency")]
        public string Currency { get; set; }

        [XmlElement("referrer")]
        public string Referer { get; set; }

        [XmlElement("originIp")]
        public string OriginIp { get; set; }

        [XmlElement("sourceName")]
        public string SourceName { get; set; }

        [XmlElement("sourceKey")]
        public string SourceKey { get; set; }

        [XmlElement("sourceCampaign")]
        public string SourceCampaign { get; set; }

        [XmlElement("total")]
        public decimal Total { get; set; }

        [XmlElement("tax")]
        public decimal Tax { get; set; }

        [XmlElement("shipping")]
        public decimal Shipping { get; set; }

        [XmlElement("customer")]
        public Customer Customer { get; set; }
        
        [XmlElement("purchaser")]
        public Customer Purchaser { get; set; }
        
        [XmlElement("address")]
        public Address Address { get; set; }

        [XmlArray("orderItems"), XmlArrayItem("orderItem")]
        public OrderItem[] OrderItems { get; set; }

        [XmlArray("payments"), XmlArrayItem("payment")]
        public Payment[] Payments { get; set; }
    }
}
