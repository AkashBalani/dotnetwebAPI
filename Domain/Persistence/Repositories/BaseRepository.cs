using lab5.Domain.Persistence.Contexts;
// The base repo receives an instance of AppDbContext

namespace lab5.Domain.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context; //Here _context is the one which gives access to do all database operations
        }
    }
}
