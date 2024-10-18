namespace Domain.Core.Services;

public interface IRepository<TEntity>
{
    void Add(TEntity entity);

    void Delete(TEntity entity);
}
