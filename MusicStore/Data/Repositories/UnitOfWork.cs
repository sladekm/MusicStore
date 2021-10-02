using MusicStore.Data.IRepositories;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        private IAlbumRepository _albums;
        private IGenericRepository<Artist> _artists;
        private ICartItemRepository _cartItems;
        private IGenericRepository<Genre> _genres;
        private IOrderRepository _orders;
        private IGenericRepository<OrderDetail> _orderDetials;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IAlbumRepository Albums => _albums ??= new AlbumRepository(_context);

        public IGenericRepository<Artist> Artists => _artists ??= new GenericRepository<Artist>(_context);

        public ICartItemRepository CartItems => _cartItems ??= new CartItemRepository(_context);

        public IGenericRepository<Genre> Genres => _genres ??= new GenericRepository<Genre>(_context);

        public IOrderRepository Orders => _orders ??= new OrderRepository(_context);

        public IGenericRepository<OrderDetail> OrderDetails => _orderDetials ??= new GenericRepository<OrderDetail>(_context);

        public async Task Save()
        {
            await _context.SaveChangesAsync(); 
        }

        private bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool dispose)
        {
            if (_disposed)
            {
                if (dispose)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }
    }
}
