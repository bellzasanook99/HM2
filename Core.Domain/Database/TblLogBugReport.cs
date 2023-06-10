using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblLogBugReport
    {
        public int Id { get; set; }
        public string BugRef { get; set; }
        public string BugTitle { get; set; }
        public string BugDetail { get; set; }
        public string Email { get; set; }
        public bool? Active { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
