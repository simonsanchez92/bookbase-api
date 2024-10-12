using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;
using Bookbase.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Bookbase.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModel
    {
        private readonly ApplicationDbContext _context;
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

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            if (typeof(ISoftDeletable).IsAssignableFrom(typeof(TEntity)))
            {
                return await GetAllSoftDeletableEntities();
            }

            return await _dbSet.ToListAsync();
        }

        private async Task<IEnumerable<TEntity>> GetAllSoftDeletableEntities()
        {
            var result = await _dbSet
            .Cast<ISoftDeletable>()
            .Where(e => !e.Deleted)
            .ToListAsync();

            return result.Cast<TEntity>();
        }


        public Task<GenericListResponse<TEntity>> GetList(int? userId, int page, int pageSize, string? query, IncludeDelegate<TEntity>? include = null)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> GetOne(int id, IncludeDelegate<TEntity>? include = null)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Update(TEntity body)
        {
            throw new NotImplementedException();
        }


    }
}
