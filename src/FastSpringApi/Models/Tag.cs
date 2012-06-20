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

        public static Tag Create(string s)
        {
            var result = new Tag();

            if (s.Contains("="))
            {
                var data = s.Split('=');

                result.Name = data[0];

                int i;
                if (int.TryParse(data[1], out i))
                {
                    result.Quantity = i;
                }
            }
            else
            {
                result.Name = s;
            }

            return result;
        }
    }
}
