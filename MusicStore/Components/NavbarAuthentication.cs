using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using System.Collections;
using System.Collections.Generic;
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
            if (_signInManager.IsSignedIn(User as ClaimsPrincipal))
            {
                var user = await _userManager.GetUserAsync(User as ClaimsPrincipal);
                ViewBag.Username = user.UserName;
                ViewBag.IsAdmin = await _userManager.IsInRoleAsync(user, "Administrator");
                return View("SignedIn");
            }
            return View("SignedOut");
        }
    }
}
