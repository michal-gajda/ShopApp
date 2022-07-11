namespace ShopApp.Application.Products.ViewModels;

public sealed record Product
{
    [JsonPropertyName("id")] public Guid Id { get; init; } = Guid.Empty;
    [JsonPropertyName("image_thumbnail_url")] public string ImageThumbnailUrl { get; init; } = string.Empty;
    [JsonPropertyName("long_description")] public string LongDescription { get; init; } = string.Empty;
    [JsonPropertyName("name")] public string Name { get; init; } = string.Empty;
    [JsonPropertyName("price")] public decimal Price { get; init; } = default;
    [JsonPropertyName("short_description")] public string ShortDescription { get; init; } = string.Empty;
}
