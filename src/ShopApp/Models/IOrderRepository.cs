namespace ShopApp.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
