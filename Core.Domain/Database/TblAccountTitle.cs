using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountTitle
    {
        public string AccountRef { get; set; }
        public string TitleBar { get; set; }
        public string TitleDetile { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
