using Applications.Core.Abstraction.Messaging;
using Domain.Core.PrimitiveTypes.Result;
using Domain.Core.Services;
using Domain.Products;

namespace Applications.Products.CreateProduct;

public class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : ICommandHandler<CreateProductCommand>
{
    public async Task<Result> Handle(CreateProductCommand command, CancellationToken token)
    {
        var productNameResult = await ProductName.CreateAsync(command.ProductName, token);

        var productDescriptionResult = await ProductDescription.CreateAsync(command.ProductDescription, token);

        var productCountResult = await ProductCount.CreateAsync(command.ProductCount, token);

        Result firstFailureOrSucces = Result.Concat(
            productNameResult,
            productDescriptionResult,
            productCountResult);

        if (firstFailureOrSucces.IsFailure)
        {
            return firstFailureOrSucces;
        }

        Product product = new(
            productNameResult.Value!,
            productDescriptionResult.Value!,
            productCountResult.Value!);

        productRepository.Add(product);

        await unitOfWork.SaveChangesAsync(token);

        return Result.Success();
    }
}  
