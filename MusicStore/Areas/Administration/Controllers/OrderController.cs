using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using MusicStore.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MusicStore.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = "Administrator")]
    public class OrderController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<AlbumController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public OrderController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<AlbumController> logger, IMapper mapper, IUnitOfWork unitOfWork, IWebHostEnvironment hostingEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string currentFilter, string searchString, int? page)
        {
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
            var orders = await _unitOfWork.Orders.GetOrdersPagedAsync(searchString: searchString, pageNumber: pageNumber);

            IEnumerable<OrderListVM> sourceList = _mapper.Map<IEnumerable<Order>, IEnumerable<OrderListVM>>(orders);
            IPagedList<OrderListVM> pagedResult = new StaticPagedList<OrderListVM>(sourceList, orders.GetMetaData());
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
