using Domain.Core.Extations;
using Domain.Core.PrimitiveTypes.Result;

namespace Domain.Products;

public record ProductDescription(string Value)
{
    public static readonly int MaximumLenght = 100;

    public static async Task<Result<ProductDescription>> CreateAsync(string productDescriprion, CancellationToken token = default)
    {
        var productDescriprionInstance = new ProductDescription(productDescriprion);
        
        return (await new ProductDescriptionValidator().ValidateAsync(productDescriprionInstance, token)).ToResult(productDescriprionInstance);
    }
}
