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
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        private readonly DbSet<Genre> _db;

        public GenreRepository(ApplicationDbContext context) : base(context)
        {
            _db = context.Set<Genre>();
        }

        public SelectList GetGenresSelectList()
        {
            var genres = _db.Select(q => new SelectListItem
            {
                Text = q.Name,
                Value = q.GenreId.ToString()
            });

            return new SelectList(genres, "Value", "Text");
        }

        public async Task<IPagedList<Genre>> GetGenresPagedAsync(string sortOrder, string searchString, int pageNumber = 1, int pageSize = 12)
        {
            IQueryable<Genre> query = _db;

            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(g => g.Name.Contains(searchString));
            }

            query = sortOrder switch
            {
                "name_desc" => query.OrderByDescending(g => g.Name),
                _ => query.OrderBy(g => g.Name)
            };

            return await query.ToPagedListAsync(pageNumber, pageSize);
        }
    }
}
