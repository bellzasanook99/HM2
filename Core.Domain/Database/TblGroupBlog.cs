using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblGroupBlog
    {
        public string GroupRef { get; set; }
        public string GroupNameTh { get; set; }
        public string GroupNameEng { get; set; }
        public string Imgurl { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
