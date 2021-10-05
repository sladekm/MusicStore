using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using MusicStore.Services.ShoppingCart;
using MusicStore.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using X.PagedList;

namespace MusicStore.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<OrderController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShoppingCart _shoppingCart;

        public OrderController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<OrderController> logger, IMapper mapper, IUnitOfWork unitOfWork, IShoppingCart shoppingCart)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _shoppingCart = shoppingCart;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.OrderIdSortParm = String.IsNullOrEmpty(sortOrder) ? "orderDate" : "";
            ViewBag.OrderDateSortParm = sortOrder == "orderId" ? "orderId_desc" : "orderId";
            ViewBag.TotalSortParm = sortOrder == "total" ? "total_desc" : "total";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            int pageNumber = page ?? 1;
            var user = await _userManager.GetUserAsync(User);
            var orders = await _unitOfWork.Orders.GetOrdersPagedAsync(sortOrder: sortOrder, searchString: searchString, pageNumber: pageNumber, userId: user.Id);

            IEnumerable<OrderListForUserVM> sourceList = _mapper.Map<IEnumerable<Order>, IEnumerable<OrderListForUserVM>>(orders);
            IPagedList<OrderListForUserVM> pagedResult = new StaticPagedList<OrderListForUserVM>(sourceList, orders.GetMetaData());
            return View(pagedResult);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int orderId)
        {
            var order = await _unitOfWork.Orders.GetOrderAsync(orderId);
            var model = _mapper.Map<OrderVM>(order);

            return View(model);
        }
    }
}
