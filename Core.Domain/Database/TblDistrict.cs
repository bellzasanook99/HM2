using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblDistrict
    {
        public string Id { get; set; }
        public int? ZipCode { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public int? AmphureId { get; set; }
    }
}
