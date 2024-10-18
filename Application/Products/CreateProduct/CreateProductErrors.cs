using Domain.Core.PrimitiveTypes;

namespace Applications.Products.CreateProduct;

internal static class CreateProductErrors
{
    internal static Error ProductNameIsRequired =>
        new Error("Prosuct.ProductNameIsRequired", "The product name is required.");
}
