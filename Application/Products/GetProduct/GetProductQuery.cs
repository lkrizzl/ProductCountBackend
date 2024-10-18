using Applications.Core.Abstraction.Messaging;
using Applications.Products.Responses;

namespace Applications.Products.GetProduct;

public record GetProductQuery(Guid Id) : IQuery<ProductResponse>;

