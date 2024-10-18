using Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Products;

public class ProductConfiguradion : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("products");

        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.Id);

        builder.ComplexProperty(x => x.ProductName, builder =>
            builder.Property(x => x.Value)
            .HasColumnName("product_name")
            .HasMaxLength(ProductName.MaximumLenght)
            .IsRequired());

        builder.ComplexProperty(x => x.ProductDescription, builder =>
            builder.Property(x => x.Value)
            .HasColumnName("product_description")
            .HasMaxLength(ProductDescription.MaximumLenght));

        builder.ComplexProperty(x => x.ProductCount, builder =>
            builder.Property(x => x.Value)
            .HasColumnName("product_count")
            .IsRequired());
    }
}
