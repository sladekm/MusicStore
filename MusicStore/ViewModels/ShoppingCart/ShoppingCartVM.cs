using MusicStore.ViewModels.CartItem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.ShoppingCart
{
    public class ShoppingCartVM
    {
        public IEnumerable<CartItemVM> CartItems { get; set; }

        [ScaffoldColumn(false)]
        public int ItemsCount { get; set; }

        [Display(Name = "Total")]
        public decimal CartTotal { get; set; }
    }
}
