using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountDesc
    {
        public int DescId { get; set; }
        public string AccountRef { get; set; }
        public string MessageTitle { get; set; }
        public string MessageDesc { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
