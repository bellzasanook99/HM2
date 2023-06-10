using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountProfile
    {
        public int ProfileId { get; set; }
        public string AccountRef { get; set; }
        public string AccountProfileRef { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
