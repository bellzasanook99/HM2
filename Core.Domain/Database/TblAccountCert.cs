using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountCert
    {
        public int CertNo { get; set; }
        public string CertRef { get; set; }
        public string AccountRef { get; set; }
        public string CertTitle { get; set; }
        public string CertPath { get; set; }
        public DateTime? Expire { get; set; }
        public string CertDesc { get; set; }
        public bool? Active { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
