using Domain.Core.PrimitiveTypes.Result;
using Domain.Core.Extations;

namespace Domain.Products;

public record ProductName(string Value)
{

    public static readonly int MinimumLenght = 4;

    public static readonly int MaximumLenght = 30;

    public static async Task<Result<ProductName>> CreateAsync(string productName, CancellationToken token = default)
    {
        var productNameIntance = new ProductName(productName);

        return (await new ProductNameValidator().ValidateAsync(productNameIntance, token)).ToResult(productNameIntance);
    }
}
