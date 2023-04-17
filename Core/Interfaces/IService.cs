using System.Linq.Expressions;

namespace Core.Interfaces;

public interface IService<TEntity> where  TEntity : class
{
    Task<TEntity> GetByIdAsync(string id);
    Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predict);

    Task<IReadOnlyList<TEntity>> ListAllAsync();
    Task<TEntity> GetEntityWithSpec(ISpecification<TEntity> specification);
    Task<IReadOnlyList<TEntity>> ListAsync(ISpecification<TEntity> specification);
    Task<int> CountAsync(ISpecification<TEntity> specification);

    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task<int> DeleteAsync(string id);
    Task<int> DeleteByEntityAsync(TEntity entity);
}