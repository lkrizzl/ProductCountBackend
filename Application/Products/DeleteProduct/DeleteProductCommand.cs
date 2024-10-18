using Applications.Core.Abstraction.Messaging;

namespace Applications.Products.DeleteProduct;

public record DeleteProductCommand(Guid Id) : ICommand;
