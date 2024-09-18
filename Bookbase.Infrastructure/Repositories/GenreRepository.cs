using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;

namespace Bookbase.Infrastructure.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Genre> Create(Genre genre)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Genre>> GetAll()
        {
            return _context.Genres.ToList();
        }

        public Task<Genre?> GetOne(int genreId)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> Update(Genre genre)
        {
            throw new NotImplementedException();
        }
    }
}
