using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountWeek
    {
        public string AccountRef { get; set; }
        public int? DayId { get; set; }
        public string DayName { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
