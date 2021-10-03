using Microsoft.EntityFrameworkCore.Query;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MusicStore.Data.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        public IAlbumRepository Albums { get; }
        public IArtistRepository Artists { get; }
        public ICartItemRepository CartItems { get; }
        public IGenreRepository Genres { get; }
        public IOrderRepository Orders { get; }
        public IGenericRepository<OrderDetail> OrderDetails { get; }
        Task Save();
    }
}
