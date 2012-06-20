using System.Linq;
using System.Collections.Generic;
using System;

namespace FastSpringApi.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public int? Quantity { get; set; }

        private Tag()
        {
        }

        public static Tag Create(string name, int quantity)
        {
            return new Tag { Name = name, Quantity = quantity };
        }

        public static Tag Create(string serializedTag)
        {
            var result = new Tag();

            if (serializedTag.Contains("="))
            {
                var data = serializedTag.Split('=');

                result.Name = data[0];

                int i;
                if (int.TryParse(data[1], out i))
                {
                    result.Quantity = i;
                }
            }
            else
            {
                result.Name = serializedTag;
            }

            return result;
        }
    }
}
