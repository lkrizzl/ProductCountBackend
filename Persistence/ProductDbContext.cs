using Domain.Products;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence;

public class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
{ 
    public DbSet<Product> Products { get; private set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}
