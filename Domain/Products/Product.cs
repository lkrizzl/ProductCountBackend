using Domain.Core.PrimitiveTypes;

namespace Domain.Products;

public class Product : Entity 
{
    private Product() : base(Guid.NewGuid()) { }

    public Product(ProductName productName, ProductDescription productDescription, ProductCount productCount)
    {
        ProductName = productName;
        ProductDescription = productDescription;
        ProductCount = productCount;
    }

    public ProductName ProductName { get; private set; }

    public ProductDescription ProductDescription { get; private set; }

    public ProductCount ProductCount { get; private set; }

    public void ChangeProductName(ProductName productName)
    {
        ProductName = productName;
    }
     
    public void ChangeProductDescription(ProductDescription productDescription)
    {
        ProductDescription = productDescription;
    }

    public void ChangeProductCount(ProductCount productCount)
    {
        ProductCount = productCount;
    }
}
