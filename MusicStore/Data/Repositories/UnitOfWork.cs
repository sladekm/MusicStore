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
        private IGenericRepository<Album> _albums;
        private IGenericRepository<Artist> _artists;
        private IGenericRepository<CartItem> _cartItems;
        private IGenericRepository<Genre> _genres;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<OrderDetail> _orderDetials;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Album> Albums => _albums ??= new GenericRepository<Album>(_context);

        public IGenericRepository<Artist> Artists => _artists ??= new GenericRepository<Artist>(_context);

        public IGenericRepository<CartItem> CartItems => _cartItems ??= new GenericRepository<CartItem>(_context);

        public IGenericRepository<Genre> Genres => _genres ??= new GenericRepository<Genre>(_context);

        public IGenericRepository<Order> Orders => _orders ??= new GenericRepository<Order>(_context);

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
