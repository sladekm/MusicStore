using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MusicStore.Data.IRepositories
{
    public interface IAlbumRepository : IGenericRepository<Album>
    {
        Task<IPagedList<Album>> GetAlbumsPagedAsync(string sortOrder = null, string searchString = null, int pageNumber = 1, int pageSize = 12);

        Task<Album> GetAlbumAsync(int albumId);
    }
}
