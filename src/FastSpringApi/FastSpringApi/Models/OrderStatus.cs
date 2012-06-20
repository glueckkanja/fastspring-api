using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public enum OrderStatus
    {
        [XmlEnum("open")] Open,
        [XmlEnum("request")] Request,
        [XmlEnum("requested")] Requested,
        [XmlEnum("acceptance")] Acceptance,
        [XmlEnum("accepted")] Accepted,
        [XmlEnum("fulfillment")] Fulfillment,
        [XmlEnum("fulfilled")] Fulfilled,
        [XmlEnum("completion")] Completion,
        [XmlEnum("completed")] Completed,
        [XmlEnum("canceled")] Canceled,
        [XmlEnum("failed")] Failed
    }
}