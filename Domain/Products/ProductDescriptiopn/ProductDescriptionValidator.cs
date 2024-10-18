using Domain.Core.Extations;
using Domain.Products.Errors;
using FluentValidation;

namespace Domain.Products;

public class ProductDescriptionValidator : AbstractValidator<ProductDescription>
{

    public ProductDescriptionValidator()
    {
        RuleFor(p => p.Value)
            .MaximumLength(ProductDescription.MaximumLenght).WithError(ProductDescriptionErrors.TooLong);
    }
}
