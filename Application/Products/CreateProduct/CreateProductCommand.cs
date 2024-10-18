using Applications.Core.Abstraction.Messaging;

namespace Applications.Products.CreateProduct;

public record CreateProductCommand(string ProductName, string ProductDescription, int ProductCount) : ICommand;
