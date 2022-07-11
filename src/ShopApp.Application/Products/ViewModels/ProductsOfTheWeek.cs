namespace ShopApp.Application.Products.ViewModels;

public sealed record ProductsOfTheWeek
{
    [JsonPropertyName("products")] public IReadOnlyList<Product> Products { get; init; } = new List<Product>();
}
