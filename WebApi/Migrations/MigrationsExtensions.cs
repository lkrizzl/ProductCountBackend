using Microsoft.EntityFrameworkCore;
using Persistence;

namespace WebApi.Migrations;

public static class MigrationsExtensions
{

    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope service = app.ApplicationServices.CreateScope();

        using ProductDbContext context = 
            service.ServiceProvider.GetRequiredService<ProductDbContext>();

        context.Database.Migrate();
    }
}
