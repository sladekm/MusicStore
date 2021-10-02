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
    public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        private readonly DbSet<Album> _db;

        public AlbumRepository(ApplicationDbContext context) : base(context)
        {
            _db = context.Set<Album>();
        }

        public async Task<IPagedList<Album>> GetAlbumsPagedAsync(string sortOrder, string searchString, int pageNumber = 1, int pageSize = 12)
        {
            IQueryable<Album> query = _db;

            query = query.Include(a => a.Genre).Include(a => a.Artist);

            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(a => a.Title.Contains(searchString) || a.Artist.Name.Contains(searchString));
            }

            query = sortOrder switch
            {
                "title_desc" => query.OrderByDescending(a => a.Title),
                "artist" => query.OrderBy(a => a.Artist.Name),
                "artist_desc" => query.OrderByDescending(a => a.Artist.Name),
                "genre" => query.OrderBy(a => a.Genre.Name),
                "genre_desc" => query.OrderByDescending(a => a.Genre.Name),
                "price" => query.OrderBy(a => a.Price),
                "price_desc" => query.OrderByDescending(a => a.Price),
                _ => query.OrderBy(a => a.Title),
            };

            return await query.ToPagedListAsync(pageNumber, pageSize);
        }
    }
}
