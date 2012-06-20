using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public enum PaymentMethod
    {
        [XmlEnum("paypal")] PayPal,
        [XmlEnum("creditcard")] CreditCard,
        [XmlEnum("test")] Test,
        [XmlEnum("check")] Check,
        [XmlEnum("purchase-order")] PurchaseOrder,
        [XmlEnum("free")] Free
    }
}