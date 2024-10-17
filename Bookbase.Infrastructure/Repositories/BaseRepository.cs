using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Bookbase.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModel
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> Create(TEntity body)
        {
            _dbSet.Add(body);
            await _context.SaveChangesAsync();
            return body;
        }

        public async Task<IEnumerable<TEntity>> GetAll(IncludeDelegate<TEntity>? include = null)
        {
            IQueryable<TEntity> query = _dbSet;


            // Check if the entity implements ISoftDeletable
            if (typeof(ISoftDeletable).IsAssignableFrom(typeof(TEntity)))
            {
                query = query.Cast<ISoftDeletable>()
                             .Where(e => !e.Deleted)
                             .Cast<TEntity>();
            }

            // Apply any Include functionality passed via the delegate
            if (include != null)
            {
                query = include(query);
            }

            return await query.ToListAsync();
        }

        public async Task<TEntity?> GetOne(int id, IncludeDelegate<TEntity>? include = null)
        {
            IQueryable<TEntity> query = _dbSet;


            // Check if the entity implements ISoftDeletable
            if (typeof(ISoftDeletable).IsAssignableFrom(typeof(TEntity)))
            {
                query = query.Cast<ISoftDeletable>()
                             .Where(e => !e.Deleted)
                             .Cast<TEntity>();
            }

            // Apply any Include functionality passed via the delegate
            if (include != null)
            {
                query = include(query);
            }

            return await query.FirstOrDefaultAsync(e => e.Id == id);
        }

        public Task<GenericListResponse<TEntity>> GetList(int? userId, int page, int pageSize, string? query, IncludeDelegate<TEntity>? include = null)
        {
            throw new NotImplementedException();
        }


        public async Task<TEntity> Update(TEntity body)
        {
            _dbSet.Update(body);
            await _context.SaveChangesAsync();
            return body;
        }

        public async Task<bool> Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
