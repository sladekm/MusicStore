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

        public string Username { get; set; }

        [Display(Name = "Billing email")]
        public string Email { get; set; }

        public decimal Total { get; set; }
    }
}
