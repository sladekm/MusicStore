using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.Genre
{
    public class GenreVM
    {
        [ScaffoldColumn(false)]
        public int GenreId { get; set; }

        public string Name { get; set; }
    }
}
