using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.Order
{
    public class OrderListVM
    {
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }

        [Display(Name = "Date ordered")]
        public DateTime OrderDate { get; set; }

        public decimal Total { get; set; }
    }
}
