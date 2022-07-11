namespace ShopApp.Infrastructure.Products.QueryHandlers;

using Microsoft.Extensions.Logging;
using ShopApp.Application.Products.Queries;
using ShopApp.Application.Products.ViewModels;
using ShopApp.Infrastructure.MartenDb.Interfaces;

internal sealed class GetProductsOfTheWeekHandler : IRequestHandler<GetProductsOfTheWeek, ProductsOfTheWeek>
{
    private readonly ILogger<GetProductsOfTheWeekHandler> logger;
    private readonly IProductsReadService productsReadService;

    public GetProductsOfTheWeekHandler(ILogger<GetProductsOfTheWeekHandler> logger, IProductsReadService productsReadService)
    {
        this.logger = logger;
        this.productsReadService = productsReadService;
    }

    public async Task<ProductsOfTheWeek> Handle(GetProductsOfTheWeek request, CancellationToken cancellationToken)
    {
        using var loggerScope = this.logger.BeginScope("Try to get products of the week");

        var products = await this.productsReadService.GetProductsOfTheWeekAsync(cancellationToken);

        var result = new ProductsOfTheWeek
        {
            Products = products,
        };

        return result;
    }
}
