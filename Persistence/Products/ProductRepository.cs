using Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Products;

public sealed class ProductRepository(ProductDbContext context) : Repository<Product>(context), IProductRepository
{
    public async Task<int> GetCoutAsync(CancellationToken token = default)
    {
        return await _dbContext.Products.CountAsync();
    }

    public async Task<Product?> GetProductByIdAsync(Guid id, CancellationToken token = default)
    {
        return await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<Product>> GetProductsAsync(CancellationToken token = default)
    {
        return await _dbContext.Products.ToListAsync();
    }
}
