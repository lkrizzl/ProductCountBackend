using Domain.Core.PrimitiveTypes;

namespace Domain.Products.Errors;

public class ProductErrors
{
    public static readonly Error ProductNameIsRequired =
          new("Registration.ProductNameIsRequired", "The Product name is required.");

    public static readonly Error NotFound =
        new("Product.NotFound", "The product with the specified identifier was not found.");
}
public class ProductCountErrors
{
    public static readonly Error LessLimit =
        new("ProductCount.LessLimit", "The count is less than the limit.");
}

public class ProductDescriptionErrors
{

    public static readonly Error TooLong =
        new("ProductDescription.TooLong", "The description is too long.");

    public static readonly Error InvalidFormat =
        new("ProductDescription.InvalidFormat", "The description format is invalid.");
}
public static class ProductNameErrors
{

    public static readonly Error TooShort =
        new("ProductName.TooShort", "The productname is too short.");

    public static readonly Error TooLong =
        new("ProductName.TooLong", "The productname is too long.");

    public static readonly Error InvalidFormat =
        new("ProductName.InvalidFormat", "The productname format is invalid.");

}
