using System.Collections.Generic;
using System.Threading.Tasks;
using lab5.Domain.Models;

namespace lab5.Domain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}
