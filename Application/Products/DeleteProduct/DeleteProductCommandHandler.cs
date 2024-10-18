using Applications.Core.Abstraction.Messaging;
using Domain.Core.PrimitiveTypes.Result;
using Domain.Core.Services;
using Domain.Products;
using Domain.Products.Errors;

namespace Applications.Products.DeleteProduct;

public class DeleteProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : ICommandHandler<DeleteProductCommand>
{

    public async Task<Result> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
    {
        Product? product = await productRepository.GetProductByIdAsync(command.Id, cancellationToken);

        if(product is null)
        {
            return Result.Failure(ProductErrors.NotFound);
        }    

        productRepository.Delete(product);

        await unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}
