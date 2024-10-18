using Applications.Core.Abstraction.Messaging;
using Applications.Products.Responses;
using Domain.Core.PrimitiveTypes.Result;
using Domain.Products;
using Mapster;

namespace Application.Products.GetProducts;

public class GetProductsQueryHandler(IProductRepository repository) : IQueryHandler<GetProductsQuery, IEnumerable<ProductResponse>>
{
    public async Task<Result<IEnumerable<ProductResponse>>> Handle(GetProductsQuery request, CancellationToken token)
    {
        var products = await repository.GetProductsAsync(token);

        var productResponses = products.Select(p => p.Adapt<ProductResponse>());

        return Result.Success(productResponses);
    }
}
