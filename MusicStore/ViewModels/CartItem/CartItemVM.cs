using MusicStore.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.CartItem
{
    public class CartItemVM
    {
        public int CartItemId { get; set; }

        public int Quantity { get; set; }

        public virtual AlbumVM Album { get; set; }
    }
}
