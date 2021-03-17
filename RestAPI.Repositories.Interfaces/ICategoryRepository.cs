using RestAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestAPI.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
