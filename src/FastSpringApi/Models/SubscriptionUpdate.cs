using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    [XmlRoot("subscription")]
    public class SubscriptionUpdate
    {
        [XmlElement("productPath")]
        public string ProductPath { get; set; }

        [XmlElement("quantity")]
        public int? Quantity { get; set; }

        [XmlElement("tags")]
        public TagCollection Tags { get; set; }

        [XmlElement("coupon")]
        public string Coupon { get; set; }

        [XmlElement("proration")]
        public bool? Proration { get; set; }
    }
}
