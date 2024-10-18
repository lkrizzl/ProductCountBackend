using Domain.Core.Extations;
using Domain.Products.Errors;
using FluentValidation;

namespace Domain.Products;

public class ProductNameValidator : AbstractValidator<ProductName>
{
    public ProductNameValidator()
    {
        RuleFor(p => p.Value)
            .MinimumLength(ProductName.MinimumLenght).WithError(ProductNameErrors.TooShort)
            .MaximumLength(ProductName.MaximumLenght).WithError(ProductNameErrors.TooLong)
            .Matches(@"^[\p{L}a-zA-Z0-9_ ]+$").WithError(ProductNameErrors.InvalidFormat);

    }

}
