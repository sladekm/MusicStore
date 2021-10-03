using Microsoft.AspNetCore.Mvc.Rendering;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MusicStore.Data.IRepositories
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        SelectList GetGenresSelectList();

        Task<IPagedList<Genre>> GetGenresPagedAsync(string sortOrder, string searchString, int pageNumber = 1, int pageSize = 12);
    }
}
