using Domain.Core.PrimitiveTypes;
using Domain.Core.Services;

namespace Persistence;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    protected readonly ProductDbContext _dbContext;

    public Repository(ProductDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(TEntity entity)
    {
        _dbContext.Add(entity);
    }

    public void Delete(TEntity entity)
    {
        _dbContext.Remove(entity);
    }
}
