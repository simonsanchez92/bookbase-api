using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Domain.Interfaces
{
    public interface IGenreRepository
    {
        public Task<Genre> Create(Genre genre);
        public Task<Genre?> GetOne(int genreId);
        public Task<Genre?> GetOne(Expression<Func<Genre, bool>> predicate);
        public Task<IEnumerable<Genre>> GetAll();
        public Task<Genre> Update(Genre genre);

        //public Task<IEnumerable<Genre?>> GetMany();
    }
}
