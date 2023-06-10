using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountBlogGay
    {
        public string AccountRef { get; set; }
        public string BlogRef { get; set; }
        public string BlogimgRef { get; set; }
        public int? BlogimgId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
