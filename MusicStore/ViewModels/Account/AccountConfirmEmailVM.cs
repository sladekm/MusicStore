using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.Account
{
    public class AccountConfirmEmailVM
    {
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public bool EmailSent { get; set; }

        [ScaffoldColumn(false)]
        public bool EmailConfirmed { get; set; }
    }
}
