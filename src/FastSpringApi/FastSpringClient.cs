using System.IO;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Net;
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

        internal void Put(string urlPart)
        {
            var req = (HttpWebRequest) WebRequest.Create(BuildUrl(urlPart));
            req.Method = "PUT";

            req.GetResponse();
        }

        internal void Delete(string urlPart)
        {
            var req = (HttpWebRequest) WebRequest.Create(BuildUrl(urlPart));
            req.Method = "DELETE";

            req.GetResponse();
        }

        private string BuildUrl(string urlPart)
        {
            return string.Format("https://api.fastspring.com/company/{2}/{3}?user={0}&pass={1}", User, Password, Company, urlPart);
        }

    }
}
