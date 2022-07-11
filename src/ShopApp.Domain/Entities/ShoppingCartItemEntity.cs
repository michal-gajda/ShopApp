namespace ShopApp.Domain.Entities;

public sealed class ShoppingCartItemEntity
{
    public ShoppingCartItemEntity(Guid id, Guid cartId)
        => (this.Id, this.CartId) = (id, cartId);

    public Guid Id { get; private set; }
    public Guid CartId { get; private set; }
    public int Amount { get; set; } = default;
    public Guid ProductId { get; set; } = Guid.Empty;
}
