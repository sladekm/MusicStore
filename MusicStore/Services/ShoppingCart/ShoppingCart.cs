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

            string cartId;

            if (httpContext.User.Identity.Name != null)
            {
                cartId = httpContext.User.Identity.Name;
            }
            else
            {
                cartId = request.Cookies["CartId"] ?? Guid.NewGuid().ToString();

                //TODO Remove cart items from database after CartId expires
                response.Cookies.Append("CartId", cartId, new CookieOptions
                {
                    Expires = DateTime.Now.AddMonths(3)
                });
            }

            return new ShoppingCart(unitOfWork)
            {
                CartId = cartId
            };
        }

        public async Task AddToCartAsync(Album album, int quantity = 1)
        {
            var cartItem = await _unitOfWork.CartItems.GetCartItemAsync(album.AlbumId, CartId);

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
            var cartItem = await _unitOfWork.CartItems.GetCartItemAsync(album.AlbumId, CartId);

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
            var cartItems = await _unitOfWork.CartItems.GetAllAsync();

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

        public async Task CreateOrderAsync(Order order)
        {
            var cartItems = await GetCartItemsAsync();
            decimal orderTotal = 0;

            var orderDetails = new List<OrderDetail>();
            foreach (var item in cartItems)
            {
                orderDetails.Add(new OrderDetail
                {
                    AlbumId = item.AlbumId,
                    OrderId = order.OrderId,
                    Quantity = item.Quantity,
                    UnitPrice = item.Album.Price
                });

                //Count order total here to avoid database call with GetTotal()
                orderTotal += (item.Quantity * item.Album.Price);
            }

            await _unitOfWork.OrderDetails.AddRangeAsync(orderDetails);

            order.Total = orderTotal;
            _unitOfWork.Orders.Update(order);
            await _unitOfWork.Save();

            await EmptyCartAsync();
        }

        public async Task MigrateCartAsync(string username)
        {
            var cartItems = await GetCartItemsAsync();

            if (cartItems != null)
            {
                foreach (var item in cartItems)
                {
                    item.CartId = username;
                }

                _unitOfWork.CartItems.UpdateRange(cartItems);
                await _unitOfWork.Save();
            }
        }
    }
}
