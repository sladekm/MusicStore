using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using MusicStore.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using X.PagedList;

namespace MusicStore.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbSet<T> _db;

        public GenericRepository(ApplicationDbContext context)
        {
            _db = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

        public async Task<IList<T>> GetAllAsync()
        {
            return await _db.ToListAsync();
        }

        public async Task<IPagedList<T>> GetAllPagedAsync(int pageNumber, int pageSize)
        {
            return await _db.ToPagedListAsync(pageNumber, pageSize);
        }

        public async Task<T> GetAsync(int id)
        {
            return await _db.FindAsync(id);
        }

        public void Remove(T entity)
        {
            _db.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _db.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _db.UpdateRange(entities);
        }
    }
}
