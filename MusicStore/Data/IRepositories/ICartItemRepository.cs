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
        Task<IList<CartItem>> GetCartItemsAsync(string cartId);
        Task<CartItem> GetCartItemAsync(int albumId, string cartId);
        int GetCount(string cartId);
        decimal GetTotal(string cartId);
    }
}