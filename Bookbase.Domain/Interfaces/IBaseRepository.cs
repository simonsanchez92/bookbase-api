using Bookbase.Domain.Common;

namespace Bookbase.Domain.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll(IncludeDelegate<TEntity>? include = null);
        Task<TEntity?> GetOne(int id, IncludeDelegate<TEntity>? include = null);
        Task<GenericListResponse<TEntity>> GetList(int? userId, int page, int pageSize, string? query, IncludeDelegate<TEntity>? include = null);
        Task<TEntity> Create(TEntity body);
        Task<TEntity> Update(TEntity body);
        Task Delete(TEntity entity); // method for hard deletes only
    }
}
