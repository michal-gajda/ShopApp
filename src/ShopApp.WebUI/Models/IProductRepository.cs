namespace ShopApp.Models
{
    using System.Collections.Generic;

    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> ProductOfTheWeek { get; }
        Product GetProductById(int id);
    }
}