using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestAPI.Data;
using RestAPI.Repositories.Interfaces;
using RestAPI.Services.Interfaces;

namespace RestAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
