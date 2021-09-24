using Microsoft.AspNetCore.Mvc;
using MusicStore.Services.ShoppingCart;
using System.Threading.Tasks;

namespace MusicStore.Components
{
    public class NavbarCartSummary : ViewComponent
    {
        private readonly IShoppingCart _shoppingCart;

        public NavbarCartSummary(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var cartItemCount = _shoppingCart.GetCount();
            
            return View(cartItemCount);
        }

    }
}
