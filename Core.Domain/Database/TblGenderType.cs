using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblGenderType
    {
        public int? GenderType { get; set; }
        public string GenderNameTh { get; set; }
        public string GenderNameEng { get; set; }
    }
}
