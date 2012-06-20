using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public enum RenewResult
    {
        Ok,
        Unavailable,
        [XmlEnum("subscription-not-active")] SubscriptionNotActive,
        [XmlEnum("rebill-limit-exceeded")] RebillLimitExceeded,
        [XmlEnum("next-charge-not-due")] NextChargeNotDue,
        [XmlEnum("unsupported-country")] UnsupportedCountry,
        [XmlEnum("expired-card")] ExpiredCard,
        [XmlEnum("declined")] Declined,
        [XmlEnum("risk")] Risk,
        [XmlEnum("processor-risk")] ProcessorRisk,
        [XmlEnum("unknown")] Unknown,
        [XmlEnum("cc-address-verification")] CcAddressVerification,
        [XmlEnum("cc-cvv")] CcCvv,
        [XmlEnum("voice-auth")] VoiceAuth
    }
}