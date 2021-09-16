using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.Manage
{
    public class ManageChangeBillingInformationVM
    {
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
    }
}
