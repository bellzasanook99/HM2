using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountService
    {
        public int ServiceNo { get; set; }
        public string AccountRef { get; set; }
        public string ServiceRef { get; set; }
        public string TitleService { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
