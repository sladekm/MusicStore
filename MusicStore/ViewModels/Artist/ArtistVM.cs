using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.Artist
{
    public class ArtistVM
    {
        [ScaffoldColumn(false)]
        public int ArtistId { get; set; }

        public string Name { get; set; }
    }
}
