using Microsoft.AspNetCore.Mvc.Rendering;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Data.IRepositories
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        SelectList GetGenresSelectList();
    }
}
