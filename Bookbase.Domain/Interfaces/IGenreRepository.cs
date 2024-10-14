using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Domain.Interfaces
{
    public interface IGenreRepository : IBaseRepository<Genre>
    {
        public Task<Genre?> GetOne(Expression<Func<Genre, bool>> predicate);
    }
}
