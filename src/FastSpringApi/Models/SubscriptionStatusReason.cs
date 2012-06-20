using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public enum SubscriptionStatusReason
    {
        [XmlEnum("canceled-non-payment")] CanceledNonPayment,
        [XmlEnum("completed")] Completed,
        [XmlEnum("canceled")] Canceled
    }
}