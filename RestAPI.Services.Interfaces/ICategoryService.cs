using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestAPI.Data;

namespace RestAPI.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
  
}
