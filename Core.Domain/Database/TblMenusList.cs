using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblMenusList
    {
        public int MenusNo { get; set; }
        public string MenusNameTh { get; set; }
        public string MenusNameEng { get; set; }
        public string ManusNameUrl { get; set; }
        public string MenusDesc { get; set; }
        public int? ManusGroup { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
