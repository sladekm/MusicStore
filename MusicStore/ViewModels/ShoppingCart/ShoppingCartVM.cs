using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.ShoppingCart
{
    public class ShoppingCartVM
    {
        public IEnumerable<CartItem> CartItems { get; set; }
        public int ItemsCount { get; set; }
        public decimal CartTotal { get; set; }
    }
}
