using Domain.Core.Extations;
using Domain.Products.Errors;
using FluentValidation;

namespace Domain.Products;

public class ProductCountValidator : AbstractValidator<ProductCount>
{

    public ProductCountValidator()
    {
        RuleFor(p => p.Value)
            .GreaterThan(ProductCount.LessLimit).WithError(ProductCountErrors.LessLimit);
    }
}
