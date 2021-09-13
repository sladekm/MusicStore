using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.ViewModels.Account
{
    public class AccountConfirmEmailVM
    {
        public string Email { get; set; }

        public bool EmailSent { get; set; }

        public bool EmailConfirmed { get; set; }
    }
}
