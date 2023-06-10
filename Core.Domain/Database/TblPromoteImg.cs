using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblPromoteImg
    {
        public string NewsRef { get; set; }
        public string NewsPath { get; set; }
        public string NewsContent { get; set; }
        public int? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
