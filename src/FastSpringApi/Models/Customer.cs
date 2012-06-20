using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public class Customer
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("company")]
        public string Company { get; set; }

        [XmlElement("email")]
        public string EMail { get; set; }

        [XmlElement("phoneNumber")]
        public string Phone { get; set; }
    }
}
