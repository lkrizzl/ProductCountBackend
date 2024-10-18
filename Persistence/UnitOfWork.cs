using Domain.Core.Services;
using Persistence;

namespace Domain.Core;

public class UnitOfWork(ProductDbContext dbContext) : IUnitOfWork
{
    public async Task<int> SaveChangesAsync(CancellationToken token = default)
    {
        return await dbContext.SaveChangesAsync(token);
    }
}