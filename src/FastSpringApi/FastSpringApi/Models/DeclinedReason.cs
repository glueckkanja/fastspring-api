using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public enum DeclinedReason
    {
        [XmlEnum("internal-error")] InternalError,
        [XmlEnum("unsupported-country")] UnsupportedCountry,
        [XmlEnum("expired-card")] ExpiredCard,
        [XmlEnum("declined")] Declined,
        [XmlEnum("risk")] Risk,
        [XmlEnum("processor-risk")] ProcessorRisk,
        [XmlEnum("connection")] Connection,
        [XmlEnum("unknown")] Unknown,
        [XmlEnum("cc-address-verification")] CcAddressVerification,
        [XmlEnum("cc-cvv")] CcCvv,
        [XmlEnum("voice-auth")] VoiceAuth
    }
}