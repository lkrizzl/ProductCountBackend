using Applications.Products.CreateProduct;
using FluentValidation;

namespace Applications.Core.Products.CreateProduct; 

public class CreateProductCommandValidation : AbstractValidator<CreateProductCommand>
{

    public CreateProductCommandValidation()
    {
        //errors
    }
}
