using Microsoft.AspNetCore.Http;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Services.ShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly IUnitOfWork _unitOfWork;

        public string CartId { get; set; }

        public ShoppingCart(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public static ShoppingCart GetCart(IUnitOfWork unitOfWork, HttpContext httpContext)
        {
            var request = httpContext.Request;
            var response = httpContext.Response;

            var cartId = request.Cookies["CartId"] ?? Guid.NewGuid().ToString();

            //TODO Remove cart items from database after CartId expires
            response.Cookies.Append("CartId", cartId, new CookieOptions
            {
                Expires = DateTime.Now.AddMonths(3)
            });

            return new ShoppingCart(unitOfWork)
            {
                CartId = cartId
            };
        }

        public async Task AddToCartAsync(Album album, int quantity = 1)
        {
            var cartItem = await _unitOfWork.CartItems.FindAsync(q => q.AlbumId == album.AlbumId && q.CartId == CartId);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    CartId = CartId,
                    AlbumId = album.AlbumId,
                    Quantity = quantity
                };

                await _unitOfWork.CartItems.AddAsync(cartItem);
                await _unitOfWork.Save();
            }
            else
            {
                cartItem.Quantity += quantity;
                _unitOfWork.CartItems.Update(cartItem);
            }
            await _unitOfWork.Save();
        }

        public async Task RemoveFromCartAsync(Album album)
        {
            var cartItem = await _unitOfWork.CartItems.FindAsync(q => q.AlbumId == album.AlbumId && q.CartId == CartId);

            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                }
                else
                {
                    _unitOfWork.CartItems.Remove(cartItem);
                }

                await _unitOfWork.Save();
            }
        }

        public async Task EmptyCartAsync()
        {
            var cartItems = await _unitOfWork.CartItems.FindAllAsync();

            if (cartItems != null)
            {
                _unitOfWork.CartItems.RemoveRange(cartItems);
                await _unitOfWork.Save();
            }
        }

        public async Task<IEnumerable<CartItem>> GetCartItemsAsync()
        {
            return await _unitOfWork.CartItems.GetCartItemsAsync(CartId);
        }

        public int GetCount()
        {
            return _unitOfWork.CartItems.GetCount(CartId);
        }

        public decimal GetTotal()
        {
            return _unitOfWork.CartItems.GetTotal(CartId);
        }
    }
}
