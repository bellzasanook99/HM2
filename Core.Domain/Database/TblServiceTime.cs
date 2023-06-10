using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblServiceTime
    {
        public int ServiceTimeNo { get; set; }
        public string ServiceRef { get; set; }
        public string ServiceTime { get; set; }
        public int? ServicePrice { get; set; }
    }
}
