using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public class Payment
    {
        [XmlElement("status")]
        public OrderStatus Status { get; set; }

        [XmlElement("statusChanged")]
        public DateTime StatusChanged { get; set; }

        [XmlElement("methodType")]
        public PaymentMethod Method { get; set; }

        [XmlElement("declinedReason")]
        public DeclinedReason? DeclinedReason { get; set; }

        [XmlElement("currency")]
        public string Currency { get; set; }

        [XmlElement("total")]
        public decimal Total { get; set; }
    }
}
