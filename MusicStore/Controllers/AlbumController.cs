using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MusicStore.Data.IRepositories;
using MusicStore.Models;
using MusicStore.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using X.PagedList;

namespace MusicStore.Controllers
{
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
        [AllowAnonymous]
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

            Expression<Func<Album, bool>> expression = null;
            Func<IQueryable<Album>, IOrderedQueryable<Album>> orderBy = null;

            if (!String.IsNullOrEmpty(searchString))
            {
                expression = a => a.Title.Contains(searchString) || a.Artist.Name.Contains(searchString);
            }

            orderBy = sortOrder switch
            {
                "title_desc" => q => q.OrderByDescending(a => a.Title),
                "artist" => q => q.OrderBy(a => a.Artist.Name),
                "artist_desc" => q => q.OrderByDescending(a => a.Artist.Name),
                "genre" => q => q.OrderBy(a => a.Genre.Name),
                "genre_desc" => q => q.OrderByDescending(a => a.Genre.Name),
                "price" => q => q.OrderBy(a => a.Price),
                "price_desc" => q => q.OrderByDescending(a => a.Price),
                _ => q => q.OrderBy(a => a.Title),
            };
            int pageNumber = page ?? 1;
            var albums = await _unitOfWork.Albums.GetPagedAsync(expression: expression, orderBy: orderBy, include: q => q.Include(x => x.Genre).Include(x => x.Artist), pageNumber: pageNumber);

            
            IEnumerable<AlbumVM> sourceList = _mapper.Map<IEnumerable<Album>, IEnumerable<AlbumVM>>(albums);
            IPagedList<AlbumVM> pagedResult = new StaticPagedList<AlbumVM>(sourceList, albums.GetMetaData());
            return View(pagedResult);
        }
    }
}
