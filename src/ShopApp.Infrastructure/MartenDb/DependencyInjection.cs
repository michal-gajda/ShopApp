namespace ShopApp.Infrastructure.MartenDb;

using Marten;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopApp.Infrastructure.MartenDb.Interfaces;
using ShopApp.Infrastructure.MartenDb.Services;
using Weasel.Core;

internal static class DependencyInjection
{
    public static IServiceCollection AddMartenDb(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddMarten(options =>
        {
            options.AutoCreateSchemaObjects = AutoCreate.All;

            options.Connection(connectionString);

        }).InitializeWith(new InitialData.InitialData());

        services.AddScoped<IProductsReadService, ProductsReadService>();

        return services;
    }
}
