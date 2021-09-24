using Microsoft.EntityFrameworkCore;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Data.IRepositories
{
    public interface ICartItemRepository : IGenericRepository<CartItem>
    {
        public Task<IEnumerable<CartItem>> GetCartItemsAsync(string cartId);
        public int GetCount(string cartId);
        public decimal GetTotal(string cartId);
    }
}