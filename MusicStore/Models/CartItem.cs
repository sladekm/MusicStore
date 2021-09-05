using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int AlbumId { get; set; }
        public string CartId { get; set; }
        public int Quantity { get; set; }
        public virtual Album Album { get; set; }
    }
}
