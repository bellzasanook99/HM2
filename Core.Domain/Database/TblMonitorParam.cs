using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblMonitorParam
    {
        public int Id { get; set; }
        public string NameTh { get; set; }
        public string NameEng { get; set; }
        public decimal? Value { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Active { get; set; }
    }
}
