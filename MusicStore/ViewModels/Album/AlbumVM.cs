using MusicStore.Models;
using MusicStore.ViewModels.Artist;
using MusicStore.ViewModels.Genre;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.Album
{
    public class AlbumVM
    {
        [ScaffoldColumn(false)]
        public int AlbumId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        [ScaffoldColumn(false)]
        public string AlbumArtUrl { get; set; }

        public GenreVM Genre { get; set; }

        public ArtistVM Artist { get; set; }
    }
}
