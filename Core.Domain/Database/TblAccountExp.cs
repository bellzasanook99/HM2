using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountExp
    {
        public int ExperienceNo { get; set; }
        public string AccountRef { get; set; }
        public string TitleExp { get; set; }
        public string Description { get; set; }
        public string ExpFilePath { get; set; }
        public bool? Active { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
