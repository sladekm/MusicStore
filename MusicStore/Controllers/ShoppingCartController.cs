using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using MusicStore.Services.ShoppingCart;
using MusicStore.ViewModels.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<ShoppingCartController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<ShoppingCartController> logger, IMapper mapper, IUnitOfWork unitOfWork, IShoppingCart shoppingCart)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _shoppingCart = shoppingCart;
        }

        // GET: ShoppingCartController
        public async Task<IActionResult> Index()
        {
            var shoppingCartVM = new ShoppingCartVM
            {
                CartItems = await _shoppingCart.GetCartItemsAsync(),
                ItemsCount = _shoppingCart.GetCount(),
                CartTotal = _shoppingCart.GetTotal()
            };

            return View(shoppingCartVM);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToCart(int albumId)
        {
            var album = await _unitOfWork.Albums.FindAsync(q => q.AlbumId == albumId);
            if (album == null)
            {
                return NotFound();
            }

            await _shoppingCart.AddToCartAsync(album);

            return RedirectToAction("Index");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveFromCart(int albumId)
        {
            var album = await _unitOfWork.Albums.FindAsync(q => q.AlbumId == albumId);
            if (album == null)
            {
                return NotFound();
            }

            await _shoppingCart.RemoveFromCartAsync(album);

            return RedirectToAction("Index");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EmptyCart()
        {
            await _shoppingCart.EmptyCartAsync();

            return RedirectToAction("Index");
        }
    }
}
