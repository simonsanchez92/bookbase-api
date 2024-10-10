using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Bookbase.Infrastructure.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly ApplicationDbContext _context;

        public LikeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Like> Create(Like like)
        {
            _context.Likes.Add(like);
            await _context.SaveChangesAsync();

            return like;
        }

        public async Task<Like?> GetOne(int reviewId, int userId)
        {
            var like = await _context.Likes
                .FirstOrDefaultAsync(l => l.UserId == userId && l.ReviewId == reviewId);

            return like;
        }
        public async Task<bool> Delete(Like like)
        {
            _context.Likes.Remove(like);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<GenericListResponse<Like>> GetList(int reviewId, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

    }
}
