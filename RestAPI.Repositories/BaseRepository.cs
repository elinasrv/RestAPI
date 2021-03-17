using System;
using RestAPI.Data.DBContext;
using RestAPI.Repositories.Interfaces;

namespace RestAPI.Repositories
{
    public abstract class BaseRepository 
    {
        protected readonly AppDbContext _context;

        protected BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
