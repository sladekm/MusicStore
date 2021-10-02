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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly DbSet<Order> _db;
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            _db = context.Set<Order>();
        }

        public async Task<IPagedList<Order>> GetPagedForUserAsync(string userId, string searchString, int pageNumber, int pageSize)
        {
            IQueryable<Order> query = _db;

            if (String.IsNullOrEmpty(userId))
            {
                return null;
            }

            query = query.Where(o => o.ApplicationUserId == userId);

            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(o => o.OrderId.ToString() == searchString || o.OrderDetails.Any(a => a.Album.Title.Contains(searchString)));
            }

            query = query.OrderByDescending(o => o.OrderDate);

            return await query.ToPagedListAsync<Order>(pageNumber, pageSize);
        }
    }
}
