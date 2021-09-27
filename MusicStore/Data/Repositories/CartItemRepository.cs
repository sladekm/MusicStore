using Microsoft.EntityFrameworkCore;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Data.Repositories
{
    public class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
    {
        private readonly DbSet<CartItem> _db;
        public CartItemRepository(ApplicationDbContext context) : base(context)
        {
            _db = context.Set<CartItem>();
        }

        public decimal GetTotal(string cartId)
        {
            return _db.Where(q => q.CartId == cartId)?.Select(q => q.Album.Price * q.Quantity).Sum() ?? 0;
        }

        public int GetCount(string cartId)
        {           
            return _db.Where(q => q.CartId == cartId)?.Select(q => q.Quantity).Sum() ?? 0;
        }

        public async Task<IList<CartItem>> GetCartItemsAsync(string cartId)
        {
            return await _db.Where(q => q.CartId == cartId).Include(q => q.Album).ToListAsync();
        }
    }
}
