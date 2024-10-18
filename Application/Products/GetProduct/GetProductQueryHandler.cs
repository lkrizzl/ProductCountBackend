using Applications.Core.Abstraction.Messaging;
using Applications.Products.Responses;
using Domain.Core.PrimitiveTypes.Result;
using Domain.Products;
using Domain.Products.Errors;
using Mapster;

namespace Applications.Products.GetProduct;

public class GetProductQueryHandler(IProductRepository productRepository) : IQueryHandler<GetProductQuery, ProductResponse>
{
    public async Task<Result<ProductResponse>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        Product? product = await productRepository.GetProductByIdAsync(request.Id, cancellationToken);

        if (product is null)
        {
            return Result.Failure<ProductResponse>(ProductErrors.NotFound);
        }

        var response = product.Adapt<ProductResponse>();

        return Result.Success(response);
    }
}
