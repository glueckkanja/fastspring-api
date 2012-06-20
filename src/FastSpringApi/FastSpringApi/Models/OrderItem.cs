using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public class OrderItem
    {
        [XmlElement("productDisplay")]
        public string ProductDisplayName { get; set; }

        [XmlElement("productName")]
        public string ProductName { get; set; }

        [XmlElement("quantity")]
        public int Quantity { get; set; }

        [XmlElement("subscriptionReference")]
        public string SubscriptionReference { get; set; }
    }
}
