
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicStore.Areas.Administration.ViewModels.Genre;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using MusicStore.ViewModels.Genre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MusicStore.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = "Administrator")]
    public class GenreController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<GenreController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public GenreController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<GenreController> logger, IMapper mapper, IUnitOfWork unitOfWork, IWebHostEnvironment hostingEnvironment)
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
            var genres = await _unitOfWork.Genres.GetGenresPagedAsync(sortOrder, searchString, pageNumber, 20);

            IEnumerable<GenreVM> sourceList = _mapper.Map<IEnumerable<Genre>, IEnumerable<GenreVM>>(genres);
            IPagedList<GenreVM> pagedResult = new StaticPagedList<GenreVM>(sourceList, genres.GetMetaData());
            return View(pagedResult);
        }

        [HttpGet]
        public IActionResult Create(string returnUrl)
        {
            var model = new GenreCreateVM();
            model.ReturnUrl = returnUrl;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GenreCreateVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var genre = _mapper.Map<Genre>(model);

            await _unitOfWork.Genres.AddAsync(genre);
            await _unitOfWork.Save();

            if (!string.IsNullOrEmpty(model.ReturnUrl))
            {
                return LocalRedirect(model.ReturnUrl);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int genreId, string returnUrl)
        {
            var genre = await _unitOfWork.Genres.GetAsync(genreId);
            if (genre == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<GenreEditVM>(genre);
            model.ReturnUrl = returnUrl;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(GenreEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var genre = _mapper.Map<Genre>(model);

            _unitOfWork.Genres.Update(genre);
            await _unitOfWork.Save();

            if (!string.IsNullOrEmpty(model.ReturnUrl))
            {
                return LocalRedirect(model.ReturnUrl);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int genreId, string returnUrl)
        {
            var genre = await _unitOfWork.Genres.GetAsync(genreId);
            if (genre == null)
            {
                return NotFound();
            }

            _unitOfWork.Genres.Remove(genre);
            await _unitOfWork.Save();

            if (!string.IsNullOrEmpty(returnUrl))
            {
                return LocalRedirect(returnUrl);
            }

            return RedirectToAction("Index");
        }
    }
}
