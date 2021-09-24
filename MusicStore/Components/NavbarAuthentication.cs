using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MusicStore.Components
{
    public class NavbarAuthentication : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public NavbarAuthentication(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (_signInManager.IsSignedIn(this.User as ClaimsPrincipal))
            {
                return View("SignedIn", await _userManager.GetUserAsync(this.User as ClaimsPrincipal));
            }
            return View("SignedOut");
        }
    }
}
