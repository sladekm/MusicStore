using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Areas.Administration.ViewModels.Genre
{
    public class GenreEditVM
    {
        [ScaffoldColumn(false)]
        public int GenreId { get; set; }

        [Required]
        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public string ReturnUrl { get; set; }
    }
}
