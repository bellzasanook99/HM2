using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccount
    {
        public int AccountNo { get; set; }
        public string AccountRef { get; set; }
        public string AccountPhone { get; set; }
        public string Password { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public int? GenderType { get; set; }
        public int? ProvinesId { get; set; }
        public int? AmphuresId { get; set; }
        public int? PermissionType { get; set; }
        public DateTime? Birthday { get; set; }
        public string CagsLists { get; set; }
        public bool? Verified { get; set; }
        public int? PageType { get; set; }
        public bool? Active { get; set; }
        public int? Astate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
