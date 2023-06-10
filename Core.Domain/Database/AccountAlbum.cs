using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Domain.Database
{
    public partial class AccountAlbum
    {
        public int AlbumNo { get; set; }
        public string AlbumRef { get; set; }
        public string AlbumName { get; set; }
    }
}
