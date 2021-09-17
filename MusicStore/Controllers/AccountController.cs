using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using MusicStore.Models;
using MusicStore.Services.EmailSender;
using MusicStore.ViewModels;
using MusicStore.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender emailSender, ILogger<AccountController> logger, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl)
        {
            var model = new AccountLoginVM
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AccountLoginVM model, string returnUrl)
        {
            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    _logger.LogInformation($"[Login] Successful - User: {model.Email}");
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }

                if (result.IsLockedOut)
                {
                    _logger.LogWarning($"[Account lock] Locked out - User: {model.Email}");
                    return View("AccountLocked");
                }

                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null && await _userManager.CheckPasswordAsync(user, model.Password) && !await _userManager.IsEmailConfirmedAsync(user))
                {
                    return RedirectToAction("ConfirmEmail", new { user.Email });
                }

                _logger.LogWarning($"[Login] Failed (Invalid login attempt) - Email used: {model.Email}");
                ModelState.AddModelError(string.Empty, "Invalid login attempt");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            _logger.LogInformation($"[Logout] Successful - User: {User.Identity.Name}");
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AccountRegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<ApplicationUser>(model);
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation($"[Registration] Successful - User: {model.Email}");
                    await _userManager.AddToRoleAsync(user, "User");
                    await SendEmailConfirmationTokenAsync(user);
                    _logger.LogInformation($"[Email confirmation] Email sent - User: {model.Email}");

                    //if (_signInManager.IsSignedIn(User) & User.IsInRole("Administrator"))
                    //{
                    //    return RedirectToAction("Users", "Administration");
                    //}
                     
                    return RedirectToAction("ConfirmEmail", new { user.Email });
                }

                _logger.LogWarning($"[Registration] Failed - User: {model.Email}");
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token, string email)
        {
            var model = new AccountConfirmEmailVM
            {
                Email = email
            };

            if (!string.IsNullOrEmpty(userId) && !string.IsNullOrEmpty(token))
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    _logger.LogWarning($"[Email confirmation] Failed (not found) - User ID: {userId}");
                    ViewBag.ErrorTitle = "Not found";
                    ViewBag.ErrorMessage = $"The user ID {userId} is invalid";
                    return View("Error");
                }

                token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (!result.Succeeded)
                {
                    _logger.LogWarning($"[Email confirmation] Failed - User: {user.Email}");
                    ViewBag.ErrorMessage = $"Error confirming your email address";
                    return View("Error");
                }

                _logger.LogInformation($"[Email confirmation] Successful - User: {user.Email}");
                model.EmailConfirmed = true;
            }

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmEmail(AccountConfirmEmailVM model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                if (user.EmailConfirmed)
                {
                    model.EmailConfirmed = true;
                    return View(model);
                } 

                await SendEmailConfirmationTokenAsync(user);
                _logger.LogInformation($"[Email confirmation] Email sent - User: {model.Email}");
                model.EmailSent = true;
                return View(model);
            }

            _logger.LogWarning($"[Email confirmation] Email sent failed - User: {model.Email}");
            ModelState.AddModelError(string.Empty, "Something went wrong");
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);

            return new ChallengeResult(provider, properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            var model = new AccountLoginVM
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            if (remoteError != null)
            {
                _logger.LogWarning($"[External login] Failed ({remoteError})");
                ModelState.AddModelError(string.Empty, remoteError);
                return View("Login", model);
            }

            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                _logger.LogWarning($"[External login] Failed (Error loading external login information)");
                ModelState.AddModelError(string.Empty, "Error loading external login information");
                return View("Login", model);
            }

            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

            if (signInResult.Succeeded)
            {
                _logger.LogInformation($"[External login] Successful - Provider key: {info.ProviderKey}");
                return LocalRedirect(returnUrl);
            }
            else
            {
                var email = info.Principal.FindFirst(ClaimTypes.Email).Value;

                if (email != null)
                {
                    var user = await _userManager.FindByEmailAsync(email);

                    //If user account with this email already exists, but is unconfirmed, delete it (someone might have mistyped email address)
                    if (user != null && !await _userManager.IsEmailConfirmedAsync(user))
                    {
                        await _userManager.DeleteAsync(user);
                        user = null;
                        _logger.LogWarning($"[External login] Deleted existing user with unconfirmed email - Email: {email}");
                    }

                    //If no account with this email address exists, create one
                    if (user == null)
                    {
                        user = new ApplicationUser
                        {
                            UserName = email,
                            Email = email,
                            EmailConfirmed = true,
                            FirstName = info.Principal.FindFirst(ClaimTypes.GivenName).Value,
                            LastName = info.Principal.FindFirst(ClaimTypes.Surname).Value
                        };

                        await _userManager.CreateAsync(user);
                        await _userManager.AddToRoleAsync(user, "User");
                        _logger.LogInformation($"[External login] Created new user - User: {user.Email}");
                    }

                    await _userManager.AddLoginAsync(user, info);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    
                    _logger.LogInformation($"[External login] Successful - User: {user.Email}");
                    return LocalRedirect(returnUrl);
                }

                _logger.LogWarning($"[External login] Failed (Email address was not recieved from {info.ProviderDisplayName})");
                ModelState.AddModelError(string.Empty, $"Email address was not recieved from {info.ProviderDisplayName}");
                return View("Login", model);

            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View(new AccountForgotPasswordVM());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(AccountForgotPasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null && await _userManager.IsEmailConfirmedAsync(user))
                {
                    await SendPasswordResetTokenAsync(user);
                    _logger.LogInformation($"[Password reset] Email sent - User: {model.Email}");
                }

                model.ResetLinkSent = true;
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string userId, string token)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
            {
                _logger.LogWarning($"[Password reset] Failed (User ID or token empty)");
                ModelState.AddModelError(string.Empty, "Invalid password reset token");
            }

            return View(new AccountResetPasswordVM());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(AccountResetPasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    var token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(model.Token));
                    var result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);
                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }

                        _logger.LogWarning($"[Password reset] Failed - User: {user.Email}");
                        return View(model);
                    }

                    //If user has successfuly reset their password, remove account lockout if active
                    if (await _userManager.IsLockedOutAsync(user))
                    {
                        await _userManager.SetLockoutEndDateAsync(user, DateTimeOffset.UtcNow);
                        _logger.LogInformation($"[Account lock] Unlocked - User: {user.Email}");
                    }
                }

                _logger.LogInformation($"[Password reset] Successful - User: {user.Email}");
                model.PasswordReset = true;
            }

            return View(model);
        }

        //Helper functions

        private async Task SendEmailConfirmationTokenAsync(ApplicationUser user)
        {
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
            var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);
            var message = new Message(user.Email, "Confirm email address", $"Please confirm your account by clicking <a href=\"{confirmationLink}\">here</a>");
            await _emailSender.SendEmailAsync(message);
        }

        private async Task SendPasswordResetTokenAsync(ApplicationUser user)
        {
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
            var confirmationLink = Url.Action("ResetPassword", "Account", new { userId = user.Id, token = token }, Request.Scheme);
            var message = new Message(user.Email, "Reset password", $"Reset your password by clicking <a href=\"{confirmationLink}\">here</a>");
            await _emailSender.SendEmailAsync(message);
        }
    }
}
