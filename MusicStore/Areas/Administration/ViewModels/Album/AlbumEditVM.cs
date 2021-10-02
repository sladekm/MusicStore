using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Areas.Administration.ViewModels.Album
{
    public class AlbumEditVM
    {
        public int AlbumId { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Required]
        [Display(Name = "Artist")]
        public int ArtistId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Album art")]
        public IFormFile AlbumArt { get; set; }

        public IEnumerable<SelectListItem> Genres { get; set; }

        public IEnumerable<SelectListItem> Artists { get; set; }

        public string ReturnUrl { get; set; }
    }
}
