namespace ShopApp.Domain.Entities;

public sealed class OrderEntity
{
    public OrderEntity(Guid id)
        => this.Id = id;

    public Guid Id { get; private set; }

    public string AddressLine1 { get; set; } = string.Empty;
    public string AddressLine2 { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public List<OrderItemEntity> Items { get; set; } = new();
    public string LastName { get; set; } = string.Empty;
    public DateTime OrderPlaced { get; set; } = DateTime.MinValue;
    public decimal OrderTotal { get; set; } = default;
    public string PhoneNumber { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
}
