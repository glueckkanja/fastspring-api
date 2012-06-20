using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public class Address
    {
        [XmlElement("addressLine1")]
        public string AddressLine1 { get; set; }

        [XmlElement("addressLine2")]
        public string AddressLine2 { get; set; }

        [XmlElement("city")]
        public string City { get; set; }

        [XmlElement("region")]
        public string Region { get; set; }

        [XmlElement("regionCustom")]
        public string RegionCustom { get; set; }

        [XmlElement("postalCode")]
        public string ZipCode { get; set; }

        [XmlElement("country")]
        public string Country { get; set; }
    }
}
