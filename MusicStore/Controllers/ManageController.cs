using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicStore.Models;
using MusicStore.Services.EmailSender;
using MusicStore.ViewModels.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;

        public ManageController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender emailSender, ILogger<AccountController> logger, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var model = _mapper.Map<ManageAccountInformationVM>(user);
            model.HasPassword = await _userManager.HasPasswordAsync(user);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            var user = await _userManager.GetUserAsync(User);
            if (!await _userManager.HasPasswordAsync(user))
            {
                return RedirectToAction("AddPassword");
            }

            return View(new ManageChangePasswordVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ManageChangePasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    _logger.LogWarning($"[Change password] Failed - User: {user.Email}");
                    return View();
                }

                await _signInManager.RefreshSignInAsync(user);

                _logger.LogInformation($"[Change password] Successful - User: {user.Email}");
                model.PasswordChanged = true;
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddPassword()
        {
            var user = await _userManager.GetUserAsync(User);
            if(await _userManager.HasPasswordAsync(user))
            {
                return RedirectToAction("ChangePassword");
            }

            return View(new ManageAddPasswordVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPassword(ManageAddPasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                var result = await _userManager.AddPasswordAsync(user, model.Password);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    _logger.LogWarning($"[Add password] Failed - User: {user.Email}");
                    return View();
                }

                await _signInManager.RefreshSignInAsync(user);

                _logger.LogInformation($"[Add password] Successful - User: {user.Email}");
                model.PasswordCreated = true;
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ChangeBillingInformation()
        {
            var user = await _userManager.GetUserAsync(User);
            var model = _mapper.Map<ManageChangeBillingInformationVM>(user);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeBillingInformation(ManageChangeBillingInformationVM model)
         {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                _mapper.Map<ManageChangeBillingInformationVM, ApplicationUser>(model, user);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    _logger.LogInformation($"[Change billing information] Successful - User: {user.Email}");
                    return RedirectToAction("Index");
                }

                _logger.LogWarning($"[Change billing information] Failed - User: {user.Email}");
                ModelState.AddModelError(string.Empty, "Something went wrong");
            }

            return View(model);
        }
    }
}
