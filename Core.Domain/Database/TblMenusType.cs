using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblMenusType
    {
        public int? ManusGroup { get; set; }
        public string GroupNameTh { get; set; }
        public string GroupNameEng { get; set; }
    }
}
