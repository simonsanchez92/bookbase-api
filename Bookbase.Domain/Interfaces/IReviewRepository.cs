using Bookbase.Domain.Models;
using System.Linq.Expressions;

namespace Bookbase.Domain.Interfaces
{
    public interface IReviewRepository : IBaseRepository<Review>
    {
        public Task<Review?> GetOne(int reviewId); //Call Base getOne
        public Task<Review?> GetOne(Expression<Func<Review, bool>> predicate);
        public Task<IEnumerable<Review>> GetBookReviews(int bookId); //calls GetAll
        public Task<bool> Delete(Review review);

    }
}
