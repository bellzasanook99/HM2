using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblServiceMenu
    {
        public string AccountRef { get; set; }
        public int? MenusTypeNo { get; set; }
        public int? MenusNo { get; set; }
        public string MenusMyDesc { get; set; }
    }
}
