using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblBlogMsg
    {
        public string AccountRef { get; set; }
        public string BlogRef { get; set; }
        public int? GroupRef { get; set; }
        public string BlogMsg { get; set; }
        public int? ParagraphId { get; set; }
        public int? PageType { get; set; }
        public string UrlRef { get; set; }
        public bool? Active { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
