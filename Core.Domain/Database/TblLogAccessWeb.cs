using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblLogAccessWeb
    {
        public int Id { get; set; }
        public string AccountRef { get; set; }
        public string AccessType { get; set; }
        public string IpAddr { get; set; }
        public string AccessPageType { get; set; }
        public string ViewAccountRef { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
