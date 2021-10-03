using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

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

        public async Task<IPagedList<Artist>> GetArtistsPagedAsync(string sortOrder, string searchString, int pageNumber = 1, int pageSize = 12)
        {
            IQueryable<Artist> query = _db;

            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(a => a.Name.Contains(searchString));
            }

            query = sortOrder switch
            {
                "name_desc" => query.OrderByDescending(a => a.Name),
                _ => query.OrderBy(a => a.Name)
            };

            return await query.ToPagedListAsync(pageNumber, pageSize);
        }
    }
}
