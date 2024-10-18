using Applications.Core.Abstraction.Messaging;

namespace Applications.Products.UpdateProduct;

public record UpdateProductCommand(Guid ProductId, string ProductName, string ProductDescription, int ProductCount) 
    : ICommand;
