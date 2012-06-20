using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public enum SubscriptionStatus
    {
        [XmlEnum("active")] Active,
        [XmlEnum("inactive")] Inactive
    }
}