using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblPermissionType
    {
        public int PermissionNo { get; set; }
        public int PermissionType { get; set; }
        public string PermissionNameTh { get; set; }
        public string PermissionNameEng { get; set; }
        public string PermissionDesc { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
