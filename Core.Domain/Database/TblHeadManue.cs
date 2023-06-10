using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblHeadManue
    {
        public int HedManuId { get; set; }
        public int? HedManuGroupId { get; set; }
        public string HedManuName { get; set; }
        public string HedMenuAction { get; set; }
        public string HedMenuController { get; set; }
        public string HedMenuUrl { get; set; }
        public int? HedMenuState { get; set; }
        public int? LagId { get; set; }

        public virtual MtbLanguage Lag { get; set; }
    }
}
