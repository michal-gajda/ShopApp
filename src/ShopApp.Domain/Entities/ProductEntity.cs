namespace ShopApp.Domain.Entities;
public sealed class ProductEntity
{
    public ProductEntity(Guid id)
        => this.Id = id;

    public Guid Id { get; private set; }

    private Guid? SourceId { get; set; } = default;
    public Guid CategoryId { get; set; } = Guid.Empty;
    public string Details { get; set; } = string.Empty;
    public string ImageThumbnailUrl { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public bool InStock { get; set; } = default;
    public bool IsActive { get; set; } = true;
    public bool IsProductOfTheWeek { get; set; } = default;
    public string LongDescription { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; } = default;
    public string ShortDescription { get; set; } = string.Empty;
}
