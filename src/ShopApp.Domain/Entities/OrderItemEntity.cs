namespace ShopApp.Domain.Entities;

public sealed class OrderItemEntity
{
    public OrderItemEntity(Guid id, Guid orderId)
     => (this.Id, this.OrderId) = (id, orderId);

    public Guid Id { get; private set; }
    public Guid OrderId { get; private set; }
    public int Amount { get; set; } = default;
    public decimal Price { get; set; } = 0;
    public Guid ProductId { get; set; } = Guid.Empty;
}
