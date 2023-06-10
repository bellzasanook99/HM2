using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblMassageNotify
    {
        public int Id { get; set; }
        public string AccountRef { get; set; }
        public int? PageType { get; set; }
        public string ViewRef { get; set; }
        public string TitelName { get; set; }
        public string Massage { get; set; }
        public bool? Active { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
