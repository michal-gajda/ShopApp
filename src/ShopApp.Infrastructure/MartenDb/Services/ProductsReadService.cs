namespace ShopApp.Infrastructure.MartenDb.Services;

using Marten;
using ShopApp.Application.Products.ViewModels;
using ShopApp.Domain.Entities;
using ShopApp.Infrastructure.MartenDb.Interfaces;

internal sealed class ProductsReadService : IProductsReadService
{
    private readonly IDocumentStore store;

    public ProductsReadService(IDocumentStore store)
        => this.store = store;

    public async Task<IReadOnlyList<Product>> GetProductsOfTheWeekAsync(CancellationToken cancellationToken = default)
    {
        using var session = this.store.LightweightSession();

        var products = session.Query<ProductEntity>()
                .Where(product => product.IsActive)
                .Where(product => product.IsProductOfTheWeek)
            ;

        var result = new List<Product>();

        foreach (var product in products)
        {
            var resultProduct = new Product
            {
                Id = product.Id,
                ImageThumbnailUrl = product.ImageThumbnailUrl,
                LongDescription = product.LongDescription,
                Name = product.Name,
                Price = product.Price,
                ShortDescription = product.ShortDescription,
            };

            result.Add(resultProduct);
        }

        return await Task.FromResult(result);
    }
}
