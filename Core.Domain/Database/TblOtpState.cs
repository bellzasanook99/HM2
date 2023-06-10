using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblOtpState
    {
        public int OtpRunningNo { get; set; }
        public string OtpRef { get; set; }
        public string AccountPhone { get; set; }
        public int? RegisType { get; set; }
        public string OtpCreated { get; set; }
        public bool? OtpState { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
