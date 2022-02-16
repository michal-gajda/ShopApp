namespace ShopApp.ViewModels
{
    using System.Collections.Generic;
    using Models;

    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
