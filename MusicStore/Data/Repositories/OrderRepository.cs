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

        public async Task<Order> GetOrderAsync(int id)
        {
            return await _db.Where(o => o.OrderId == id).Include(o => o.OrderDetails).ThenInclude(od => od.Album).FirstOrDefaultAsync();
        }

        public async Task<IPagedList<Order>> GetOrdersPagedAsync(string sortOrder, string searchString, int pageNumber, int pageSize, string userId)
        {
            IQueryable<Order> query = _db;

            if (!String.IsNullOrEmpty(userId))
            {
                query = query.Where(o => o.ApplicationUserId == userId);
            }
            else
            {
                query = query.Include(o => o.ApplicationUser);
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(o => o.OrderId.ToString() == searchString || o.OrderDetails.Any(a => a.Album.Title.Contains(searchString)));
            }

            query = sortOrder switch
            {
                "orderDate" => query.OrderBy(a => a.OrderDate),
                "orderId" => query.OrderBy(a => a.OrderId),
                "orderId_desc" => query.OrderByDescending(a => a.OrderId),
                "username" => query.OrderBy(a => a.ApplicationUser.UserName),
                "username_desc" => query.OrderByDescending(a => a.ApplicationUser.UserName),
                "email" => query.OrderBy(a => a.Email),
                "email_desc" => query.OrderByDescending(a => a.Email),
                "total" => query.OrderBy(a => a.Total),
                "total_desc" => query.OrderByDescending(a => a.Total),
                _ => query.OrderByDescending(o => o.OrderDate),
            };

            return await query.ToPagedListAsync<Order>(pageNumber, pageSize);
        }
    }
}
