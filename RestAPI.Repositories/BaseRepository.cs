using System;
using RestAPI.Data.DBContext;
using RestAPI.Repositories.Interfaces;

namespace RestAPI.Repositories
{
    public abstract class BaseRepository //: IBaseRepository
    {
        protected readonly AppDbContext _context;
        //private bool _disposed;

        protected BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (_disposed)
        //        return;

        //    if (disposing)
        //        _context.Dispose();

        //    _disposed = true;
        //}
    }
}
