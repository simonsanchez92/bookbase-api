using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Bookbase.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;

namespace Bookbase.Infrastructure.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Comment> Create(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            return comment;
        }
        public async Task<Comment?> GetOne(int commentId)
        {
            var comment = await _context.Comments
                .Include(c => c.User)
                .FirstOrDefaultAsync(c => c.Id == commentId);

            return comment;
        }

        public async Task<GenericListResponse<Comment>> GetList(int reviewId, int page, int pageSize)
        {
            // Params
            // TODO: cambiar
            var query = _context.Comments
                .Include(c => c.User)
                .Where(c => c.ReviewId == reviewId);

            // TODO: aplicaría filtros

            //Pagination
            int total = await query.CountAsync();

            //
            int currentPage = page < 1 ? PaginationConstants.DefaultPage : page;
            int currentLength = pageSize < 1 ? PaginationConstants.DefaultPageSize : pageSize;

            //
            int skip = (currentPage - 1) * currentLength;

            query = query.Skip(skip).Take(currentLength);
            var data = await query.ToListAsync();

            return new GenericListResponse<Comment>
            {
                Total = total,
                Page = page,
                Length = pageSize,
                Data = data
            };
        }

    }
}
