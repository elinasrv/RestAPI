using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Data;
using RestAPI.Helper;
using RestAPI.Services.Interfaces;

namespace RestAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController()
        {
             _categoryService = ServiceProviderHelper.GetService<ICategoryService>();
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}
