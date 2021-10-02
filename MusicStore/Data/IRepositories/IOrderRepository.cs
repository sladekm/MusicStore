using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MusicStore.Data.IRepositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        public Task<IPagedList<Order>> GetOrdersForUserPagedAsync(string userId, string searchString, int pageNumber = 1, int pageSize = 12);

        public Task<Order> GetOrderAsync(int id);
    }
}
