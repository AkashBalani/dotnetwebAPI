using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using lab5.Domain.Services;
using lab5.Domain.Models;

namespace lab5.Controllers //sort of like a package in Java
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
      private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            // Looks like a constructor
            _categoryService = categoryService; //The underscore here works like the 'this' keyword
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}
