using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bookbase.Infrastructure.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {

        public ReviewRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Review?> GetOne(int reviewId)
        {
            return await base.GetOne(reviewId, query =>

            query.Include(r => r.User)
            .Include(r => r.Comments)
            .Include(r => r.Likes));
        }

        public async Task<Review?> GetOne(Expression<Func<Review, bool>> predicate)
        {
            return await _context.Reviews.FirstOrDefaultAsync(predicate);
        }
        public async Task<IEnumerable<Review>> GetBookReviews(int bookId)
        {
            var bookReviews = await base.GetAll(query =>
                query.Include(r => r.User)
                .Include(r => r.Comments)
                .Include(r => r.Likes)
                .Where(r => r.BookId == bookId)
            );

            return bookReviews;
        }

    }
}
