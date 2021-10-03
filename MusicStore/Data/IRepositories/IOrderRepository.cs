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
        public Task<IPagedList<Order>> GetOrdersPagedAsync(string searchString = null, int pageNumber = 1, int pageSize = 12, string userId = null);

        public Task<Order> GetOrderAsync(int id);
    }
}
