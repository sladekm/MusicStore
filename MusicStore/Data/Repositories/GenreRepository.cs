﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
