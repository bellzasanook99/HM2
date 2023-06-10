using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountNetwork
    {
        public int NetworkId { get; set; }
        public string AccountRefNetwork { get; set; }
        public string AccountRef { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
