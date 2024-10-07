using Bookbase.Domain.Models;

namespace Bookbase.Domain.Interfaces
{
    public interface IReviewRepository
    {
        public Task<Review> Create(Review review);
        public Task<Review?> GetOne(int reviewId);
        public Task<IEnumerable<Review>> GetBookReviews(int bookId);
        //public Task<Genre?> GetOne(Expression<Func<Genre, bool>> predicate);
        //public Task<IEnumerable<Genre>> GetAll();
    }
}
