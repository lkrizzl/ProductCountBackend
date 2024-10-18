using Applications.Core.Abstraction.Messaging;
using Applications.Products.Responses;

namespace Application.Products.GetProducts;

public record GetProductsQuery() : IQuery<IEnumerable<ProductResponse>>;
