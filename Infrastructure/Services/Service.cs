using System.Linq.Expressions;
using Core.Interfaces;

namespace Infrastructure.Services;

public class Service<TEntity> : IService<TEntity> where TEntity : class
{
    protected IUnitOfWork UnitOfWork { get; private set; }

    protected IGenericRepository<TEntity> Repository { get; private set; }
    
    public Service(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork)
    {
        Repository = repository;
        UnitOfWork = unitOfWork;
    }
    
    public Task<TEntity> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predict)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<TEntity>> ListAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetEntityWithSpec(ISpecification<TEntity> specification)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<TEntity>> ListAsync(ISpecification<TEntity> specification)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(ISpecification<TEntity> specification)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteByEntityAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}