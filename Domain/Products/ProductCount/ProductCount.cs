using Domain.Core.Extations;
using Domain.Core.PrimitiveTypes.Result;

namespace Domain.Products;

public record ProductCount(int Value)
{
    public static readonly int LessLimit = 0;

    public static async Task<Result<ProductCount>> CreateAsync(int productCount, CancellationToken token = default)
    {
        var productCountInstance = new ProductCount(productCount);

        return (await new ProductCountValidator().ValidateAsync(productCountInstance, token)).ToResult(productCountInstance);
    }
}
