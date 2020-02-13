using System.Collections.Generic;
using System.Threading.Tasks;
using lab5.Domain.Models;
using lab5.Domain.Services;
using lab5.Domain.Repositories;

namespace lab5.Domain.Services
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
