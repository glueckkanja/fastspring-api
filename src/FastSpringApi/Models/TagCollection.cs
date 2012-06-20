using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FastSpringApi.Models
{
    public class TagCollection : ICollection<Tag>, IXmlSerializable
    {
        private HashSet<Tag> _tags;

        public TagCollection()
        {
            _tags = new HashSet<Tag>();
        }

        public TagCollection(IEnumerable<Tag> tags)
        {
            _tags = new HashSet<Tag>(tags);
        }

        #region Implementation of IEnumerable

        public IEnumerator<Tag> GetEnumerator()
        {
            return _tags.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Implementation of ICollection<Tag>

        public void Add(Tag item)
        {
            _tags.Add(item);
        }

        public void Clear()
        {
            _tags.Clear();
        }

        public bool Contains(Tag item)
        {
            return _tags.Contains(item);
        }

        public void CopyTo(Tag[] array, int arrayIndex)
        {
            _tags.CopyTo(array, arrayIndex);
        }

        public bool Remove(Tag item)
        {
            return _tags.Remove(item);
        }

        public int Count
        {
            get { return _tags.Count; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        #endregion

        private static string SerializeTag(Tag t)
        {
            return t.Quantity.HasValue
                       ? string.Format("{0}={1}", t.Name, t.Quantity)
                       : t.Name;
        }

        #region Implementation of IXmlSerializable

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            var content = reader.ReadElementContentAsString();

            _tags = new HashSet<Tag>(content.Split(new[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(t => Tag.Create(t)));
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteValue(string.Join(",", _tags.Select(SerializeTag)));
        }

        #endregion
    }
}
