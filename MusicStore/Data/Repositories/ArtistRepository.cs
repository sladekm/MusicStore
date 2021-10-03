using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Data.Repositories
{
    public class ArtistRepository : GenericRepository<Artist>, IArtistRepository
    {
        private readonly DbSet<Artist> _db;

        public ArtistRepository(ApplicationDbContext context) : base(context)
        {
            _db = context.Set<Artist>();
        }
        public SelectList GetArtistsSelectList()
        {
            var artists = _db.Select(q => new SelectListItem
            {
                Text = q.Name,
                Value = q.ArtistId.ToString()
            });

            return new SelectList(artists, "Value", "Text");
        }
    }
}
