using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MusicStore.Areas.Administration.ViewModels.Album;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using MusicStore.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MusicStore.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = "Administrator")]
    public class AlbumController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<AlbumController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AlbumController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<AlbumController> logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.TitleSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.ArtistSortParm = sortOrder == "artist" ? "artist_desc" : "artist";
            ViewBag.GenreSortParm = sortOrder == "genre" ? "genre_desc" : "genre";
            ViewBag.PriceSortParm = sortOrder == "price" ? "price_desc" : "price";

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
            var albums = await _unitOfWork.Albums.GetAlbumsPagedAsync(sortOrder, searchString, pageNumber);

            IEnumerable<AlbumVM> sourceList = _mapper.Map<IEnumerable<Album>, IEnumerable<AlbumVM>>(albums);
            IPagedList<AlbumVM> pagedResult = new StaticPagedList<AlbumVM>(sourceList, albums.GetMetaData());
            return View(pagedResult);
        }

        [HttpGet]
        public async Task<IActionResult> Create(string returnUrl)
        {
            var model = new AlbumCreateVM();
            model.ReturnUrl = returnUrl;

            var genres = await _unitOfWork.Genres.GetAllAsync();
            model.Genres = genres.Select(q => new SelectListItem
            {
                Text = q.Name,
                Value = q.GenreId.ToString()
            });

            var artists = await _unitOfWork.Artists.GetAllAsync();
            model.Artists = artists.Select(q => new SelectListItem
            {
                Text = q.Name,
                Value = q.ArtistId.ToString()
            });

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AlbumCreateVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (String.IsNullOrEmpty(model.AlbumArtUrl))
            {
                model.AlbumArtUrl = "~/images/placeholder.gif";
            }

            var album = _mapper.Map<Album>(model);

            await _unitOfWork.Albums.AddAsync(album);
            await _unitOfWork.Save();

            if (!string.IsNullOrEmpty(model.ReturnUrl))
            {
                return LocalRedirect(model.ReturnUrl);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int albumId, string returnUrl)
        {
            var album = await _unitOfWork.Albums.GetAlbumAsync(albumId);
            if (album == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<AlbumEditVM>(album);
            model.ReturnUrl = returnUrl;

            var genres = await _unitOfWork.Genres.GetAllAsync();           
            model.Genres = genres.Select(q => new SelectListItem
            {
                Text = q.Name,
                Value = q.GenreId.ToString()
            });

            var artists = await _unitOfWork.Artists.GetAllAsync();
            model.Artists = artists.Select(q => new SelectListItem
            {
                Text = q.Name,
                Value = q.ArtistId.ToString()
            });

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AlbumEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (String.IsNullOrEmpty(model.AlbumArtUrl))
            {
                model.AlbumArtUrl = "~/images/placeholder.gif";
            }

            var album = _mapper.Map<Album>(model);

            _unitOfWork.Albums.Update(album);
            await _unitOfWork.Save();

            if (!string.IsNullOrEmpty(model.ReturnUrl))
            {
                return LocalRedirect(model.ReturnUrl);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int albumId, string returnUrl)
        {
            var album = await _unitOfWork.Albums.GetAsync(albumId);
            if (album == null)
            {
                return NotFound();
            }

            _unitOfWork.Albums.Remove(album);
            await _unitOfWork.Save();

            if (!string.IsNullOrEmpty(returnUrl))
            {
                return LocalRedirect(returnUrl);
            }

            return RedirectToAction("Index");
        }
    }
}
