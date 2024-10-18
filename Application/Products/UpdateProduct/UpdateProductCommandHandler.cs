using Applications.Core.Abstraction.Messaging;
using Domain.Core.PrimitiveTypes.Result;
using Domain.Core.Services;
using Domain.Products;
using Domain.Products.Errors;

namespace Applications.Products.UpdateProduct;

public class UpdateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) 
    : ICommandHandler<UpdateProductCommand>
{
    public async Task<Result> Handle(UpdateProductCommand command, CancellationToken cancellationToken = default)
    {
        
        var productNameResult = await ProductName.CreateAsync(command.ProductName);

        var productDescriptionResult = await ProductDescription.CreateAsync(command.ProductDescription);

        var productCountResult = await ProductCount.CreateAsync(command.ProductCount);

        Result firstFailureOrSucces = Result.Concat(productNameResult, productDescriptionResult, productCountResult);

        if(firstFailureOrSucces.IsFailure)
        {
            return Result.Failure(productNameResult.Errors);
        }

        Product? product = await productRepository.GetProductByIdAsync(command.ProductId, cancellationToken);

        if(product is null) 
        {
            return Result.Failure(ProductErrors.NotFound);
        }

        product.ChangeProductName(productNameResult.Value);

        product.ChangeProductDescription(productDescriptionResult.Value);

        product.ChangeProductCount(productCountResult.Value);

        await unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}
