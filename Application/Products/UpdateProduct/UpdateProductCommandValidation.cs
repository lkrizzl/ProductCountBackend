using Domain.Core.Extations;
using Domain.Products.Errors;
using FluentValidation;

namespace Applications.Products.UpdateProduct;

public class UpdateProductCommandValidation : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidation()
    {
        RuleFor(c => c.ProductName)
            .NotEmpty()
                .WithError(ProductErrors.ProductNameIsRequired);
    }
}
