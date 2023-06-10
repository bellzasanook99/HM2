using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountReview
    {
        public string BlogRef { get; set; }
        public string AccountRef { get; set; }
        public string MsgReview { get; set; }
        public double? Rateing { get; set; }
        public int? Active { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
