using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblMedium
    {
        public string AccountRef { get; set; }
        public string VdoRef { get; set; }
        public string VdoTitleName { get; set; }
        public string VdoFileName { get; set; }
        public string VdoFileTitleName { get; set; }
        public int? PageType { get; set; }
        public int? Active { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
