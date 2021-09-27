using MusicStore.ViewModels.Album;
using MusicStore.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.OrderDetail
{
    public class OrderDetailVM
    {
        public int Quantity { get; set; }
        
        [Display(Name = "Unit price")]
        public decimal UnitPrice { get; set; }

        public AlbumVM Album { get; set; }
    }
}
