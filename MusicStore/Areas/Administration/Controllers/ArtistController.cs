using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicStore.Areas.Administration.ViewModels.Artist;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using MusicStore.ViewModels.Artist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MusicStore.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = "Administrator")]
    public class ArtistController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<ArtistController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ArtistController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<ArtistController> logger, IMapper mapper, IUnitOfWork unitOfWork, IWebHostEnvironment hostingEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

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
            var artists = await _unitOfWork.Artists.GetArtistsPagedAsync(sortOrder, searchString, pageNumber, 20);

            IEnumerable<ArtistVM> sourceList = _mapper.Map<IEnumerable<Artist>, IEnumerable<ArtistVM>>(artists);
            IPagedList<ArtistVM> pagedResult = new StaticPagedList<ArtistVM>(sourceList, artists.GetMetaData());
            return View(pagedResult);
        }

        [HttpGet]
        public IActionResult Create(string returnUrl)
        {
            var model = new ArtistCreateVM();
            model.ReturnUrl = returnUrl;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArtistCreateVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var artist = _mapper.Map<Artist>(model);

            await _unitOfWork.Artists.AddAsync(artist);
            await _unitOfWork.Save();

            if (!string.IsNullOrEmpty(model.ReturnUrl))
            {
                return LocalRedirect(model.ReturnUrl);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int artistId, string returnUrl)
        {
            var artist = await _unitOfWork.Artists.GetAsync(artistId);
            if (artist == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<ArtistEditVM>(artist);
            model.ReturnUrl = returnUrl;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ArtistEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var artist = _mapper.Map<Artist>(model);

            _unitOfWork.Artists.Update(artist);
            await _unitOfWork.Save();

            if (!string.IsNullOrEmpty(model.ReturnUrl))
            {
                return LocalRedirect(model.ReturnUrl);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int artistId, string returnUrl)
        {
            var artist = await _unitOfWork.Artists.GetAsync(artistId);
            if (artist == null)
            {
                return NotFound();
            }

            _unitOfWork.Artists.Remove(artist);
            await _unitOfWork.Save();

            if (!string.IsNullOrEmpty(returnUrl))
            {
                return LocalRedirect(returnUrl);
            }

            return RedirectToAction("Index");
        }
    }
}
