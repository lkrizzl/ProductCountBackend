using Applications.Products.Responses;
using Domain.Products;
using Mapster;

namespace WebApi.MapConfigs;

public class ProductsMapConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Product, ProductResponse>()
            .MapToConstructor(true)
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.ProductName, src => src.ProductName.Value)
            .Map(dest => dest.ProductDescription, src => src.ProductDescription.Value)
            .Map(dest => dest.ProductCount, src => src.ProductCount.Value);
    }
}
