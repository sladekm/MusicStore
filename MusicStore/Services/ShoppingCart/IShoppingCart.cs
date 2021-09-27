using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Services.ShoppingCart
{
    public interface IShoppingCart
    {
        string CartId { get; set; }

        Task AddToCartAsync(Album album, int quantity = 1);
        Task RemoveFromCartAsync(Album album);
        Task EmptyCartAsync();
        Task<IEnumerable<CartItem>> GetCartItemsAsync();
        Task CreateOrderAsync(Order order);
        Task MigrateCartAsync(string username);
        int GetCount();
        decimal GetTotal();
    }
}
