using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountAlbum
    {
        public string AccountRef { get; set; }
        public string GalleryRef { get; set; }
        public string AlbumRef { get; set; }
        public int? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
