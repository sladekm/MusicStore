using MusicStore.ViewModels.OrderDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.Order
{
    public class OrderVM
    {
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }

        [Display(Name = "Order date")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }

        public string Country { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        public IEnumerable<OrderDetailVM> OrderDetails { get; set; }
    }
}
