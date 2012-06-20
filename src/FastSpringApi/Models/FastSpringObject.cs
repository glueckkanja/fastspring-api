using System.Linq;
using System.Collections.Generic;
using System;

namespace FastSpringApi.Models
{
    public abstract class FastSpringObject
    {
        internal FastSpringClient Client { get; set; }
    }
}
