namespace Bookbase.Domain.Common
{
    public delegate IQueryable<TEntity> IncludeDelegate<TEntity>(IQueryable<TEntity> query);

}
