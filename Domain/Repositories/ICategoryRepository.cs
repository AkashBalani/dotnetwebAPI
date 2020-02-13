using System.Collections.Generic;
using System.Threading.Tasks;
using lab5.Domain.Models;

namespace lab5.Domain.Repositories
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}
