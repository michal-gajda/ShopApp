namespace ShopApp.Application.Products.Queries;

using ShopApp.Application.Products.ViewModels;

public sealed record GetProductsOfTheWeek : IRequest<ProductsOfTheWeek>
{
}
