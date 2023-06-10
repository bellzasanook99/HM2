using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAmphure
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public int? ProvinceId { get; set; }
    }
}
