using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class TblAccountGallery
    {
        public string AccountRef { get; set; }
        public string GalleryPath { get; set; }
        public string AlbumRef { get; set; }
        public int? Active { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
