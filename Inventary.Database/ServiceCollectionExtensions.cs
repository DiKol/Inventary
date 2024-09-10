using System.Reflection;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Mbr.Inventary.Infrastructure.Database;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
    {
        DbContextOptionsBuilder<InventoryContext> optionsBuilder = new();
        optionsBuilder.UseNpgsql(connectionString);
  
        services.AddDbContext<InventoryContext>(
                options => options.UseNpgsql(connectionString));

        services.AddScoped<DbContext,InventoryContext>();
        return services;
    }
}
