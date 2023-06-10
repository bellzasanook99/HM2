using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountInfo
    {
        public int AccountNo { get; set; }
        public string AccountRef { get; set; }
        public string AccountPhone { get; set; }
        public string Password { get; set; }
        public int? PermissionType { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public int? GenderType { get; set; }
        public string BusinessName { get; set; }
        public string Description { get; set; }
        public string GoogleLink { get; set; }
        public string Address { get; set; }
        public int? AddressProvince { get; set; }
        public int? AddressCity { get; set; }
        public string PostalCode { get; set; }
        public int? ServiceType { get; set; }
        public string ExpYear { get; set; }
        public string ExTech { get; set; }
        public string AnotPro { get; set; }
        public string CallOuts { get; set; }
        public string CallIns { get; set; }
        public string ProfilePath { get; set; }
        public string Email { get; set; }
        public bool? Verified { get; set; }
        public string Review { get; set; }
        public bool? Active { get; set; }
        public bool? RegisActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
