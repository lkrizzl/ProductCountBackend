using Microsoft.EntityFrameworkCore;
using Persistence;

namespace WebApi.Extensions;

public static class MigrationsExtensions
{


    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope serviceScope = app.ApplicationServices.CreateScope();

        using ProductDbContext context = serviceScope.ServiceProvider.GetRequiredService<ProductDbContext>();

        context.Database.Migrate();
    }
}
