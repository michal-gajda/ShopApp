namespace ShopApp.Domain.Entities;

public sealed class CategoryEntity
{
    public CategoryEntity(Guid id)
        => this.Id = id;

    public Guid Id { get; private set; }
    public string Description { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
