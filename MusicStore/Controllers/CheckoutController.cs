 using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using MusicStore.Services.ShoppingCart;
using MusicStore.ViewModels.CartItem;
using MusicStore.ViewModels.Checkout;
using MusicStore.ViewModels.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<CheckoutController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShoppingCart _shoppingCart;

        public CheckoutController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<CheckoutController> logger, IMapper mapper, IUnitOfWork unitOfWork, IShoppingCart shoppingCart)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _shoppingCart = shoppingCart;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> BillingInformation()
        {
            var cartItems = await _shoppingCart.GetCartItemsAsync();
            if (!cartItems.Any())
            {
                return RedirectToAction("Index", "ShoppingCart");
            }

            var model = new CheckoutBillingInformationVM();
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                model = _mapper.Map<CheckoutBillingInformationVM>(user);
            }

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult BillingInformation(CheckoutBillingInformationVM model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Summary", model);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Summary(CheckoutBillingInformationVM model)
        {
            if (ModelState.IsValid)
            {
                var cartItems = await _shoppingCart.GetCartItemsAsync();
                if (!cartItems.Any())
                {
                    return RedirectToAction("Index", "ShoppingCart");
                }

                var checkoutSummaryModel = _mapper.Map<CheckoutSummaryVM>(model);
                checkoutSummaryModel.CartItems = _mapper.Map<IEnumerable<CartItemVM>>(cartItems);
                checkoutSummaryModel.CartTotal = _shoppingCart.GetTotal();

                return View(checkoutSummaryModel);
            }

            return View("BillingInformation", model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Summary(CheckoutSummaryVM model)
        {
            if (ModelState.IsValid)
            {
                var cartItems = await _shoppingCart.GetCartItemsAsync();
                if (!cartItems.Any())
                {
                    return RedirectToAction("Index", "ShoppingCart");
                }

                var order = _mapper.Map<Order>(model);
                order.OrderDate = DateTime.Now;

                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    order.ApplicationUserId = user.Id;
                }

                await _unitOfWork.Orders.AddAsync(order);
                await _unitOfWork.Save();
                await _shoppingCart.CreateOrderAsync(order);

                return RedirectToAction("OrderPlaced", new { orderId = order.OrderId });
            }

            return RedirectToAction("Index", "ShoppingCart");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult OrderPlaced(int orderId)
        {
            return View(orderId);
        }
    }
}
