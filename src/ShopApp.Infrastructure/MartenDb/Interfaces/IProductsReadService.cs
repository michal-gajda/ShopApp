namespace ShopApp.Infrastructure.MartenDb.Interfaces;

using ShopApp.Application.Products.ViewModels;

internal interface IProductsReadService
{
    Task<IReadOnlyList<Product>> GetProductsOfTheWeekAsync(CancellationToken cancellationToken = default);
}
