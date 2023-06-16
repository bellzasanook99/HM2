using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class AppSettings
    {
        public string Secret { get; set; }
    }

    public class DomainSettings
    {
        public string CoreAPIUrl { get; set; }
    }
}
