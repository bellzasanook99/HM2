using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblProvince
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public string Imgurl { get; set; }
        public int? GeographyId { get; set; }
    }
}
