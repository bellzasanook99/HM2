using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountCover
    {
        public int CoverId { get; set; }
        public string AccountRef { get; set; }
        public string AccountCoverRef { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
