using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblReview
    {
        public int ReviewNo { get; set; }
        public string AccountRef { get; set; }
        public string AccountReview { get; set; }
        public string Description { get; set; }
        public string Review { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
