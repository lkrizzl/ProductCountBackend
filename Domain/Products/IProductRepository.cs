using Domain.Core.Services;

namespace Domain.Products;

public interface IProductRepository : IRepository<Product>
{
    Task<IEnumerable<Product>> GetProductsAsync(CancellationToken token = default);

    Task<Product?> GetProductByIdAsync(Guid id, CancellationToken token = default);

    Task<int> GetCoutAsync(CancellationToken token = default);
}
