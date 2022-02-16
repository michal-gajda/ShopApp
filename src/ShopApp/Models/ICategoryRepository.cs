namespace ShopApp.Models
{
    using System.Collections.Generic;

    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
