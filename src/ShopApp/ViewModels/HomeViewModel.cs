namespace ShopApp.ViewModels
{
    using System.Collections.Generic;
    using Models;

    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOfTheWeek { get; set; }
    }
}
