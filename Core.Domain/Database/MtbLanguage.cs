using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class MtbLanguage
    {
        public int LagId { get; set; }
        public string LagName { get; set; }
        public string LagNameshot { get; set; }
        public string LagUrl { get; set; }
    }
}
