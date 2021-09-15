using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.Account
{
    public class AccountForgotPasswordVM
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public bool ResetLinkSent { get; set; }
    }
}
