using System.IO;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Net;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using FastSpringApi.Models;

namespace FastSpringApi
{
    public class FastSpringClient
    {
        public string Company { get; private set; }
        public string User { get; private set; }
        public string Password { get; private set; }

        public FastSpringClient(string company, string user, string password)
        {
            Company = company;
            User = user;
            Password = password;
        }

        public Order GetOrder(string reference)
        {
            var order = Get<Order>("order/" + reference);
            order.Client = this;

            return order;
        }

        public Subscription GetSubscription(string reference)
        {
            var subscription = Get<Subscription>("subscription/" + reference);
            subscription.Client = this;

            return subscription;
        }

        internal T Get<T>(string urlPart)
        {
            var req = (HttpWebRequest) WebRequest.Create(BuildUrl(urlPart));
            var stream = req.GetResponse().GetResponseStream();

            if (stream == null)
            {
                return default(T);
            }

            var serializer = new XmlSerializer(typeof (T));
            return (T) serializer.Deserialize(new StreamReader(stream));
        }

        internal void Post(string urlPart)
        {
            var req = (HttpWebRequest) WebRequest.Create(BuildUrl(urlPart));
            req.Method = "POST";

            req.GetResponse();
        }

        internal void Put(string urlPart, string body = null)
        {
            var req = (HttpWebRequest) WebRequest.Create(BuildUrl(urlPart));
            req.Method = "PUT";

            if (body != null)
            {
                using (var sr = new StreamWriter(req.GetRequestStream()))
                {
                    sr.Write(body);
                }
            }

            req.GetResponse();
        }

        internal void Delete(string urlPart)
        {
            var req = (HttpWebRequest) WebRequest.Create(BuildUrl(urlPart));
            req.Method = "DELETE";

            req.GetResponse();
        }

        /// <summary>
        /// Removes all the stuff <see cref="XmlSerializer"/> added which is unnecessary.
        /// </summary>
        /// <param name="xml">The XML string to clean-up</param>
        public static string CleanUpXml(string xml)
        {
            var doc = XDocument.Parse(xml);

            var xsi = XNamespace.Get("http://www.w3.org/2001/XMLSchema-instance");

            doc.Descendants().Where(e => e.Attribute(xsi + "nil") != null && (bool) e.Attribute(xsi + "nil")).Remove();
            doc.Root.Attributes().Remove();

            return doc.ToString(SaveOptions.DisableFormatting); // don't use Save() to omit XDeclaration
        }

        private string BuildUrl(string urlPart)
        {
            return string.Format("https://api.fastspring.com/company/{2}/{3}?user={0}&pass={1}", User, Password, Company, urlPart);
        }

    }
}
