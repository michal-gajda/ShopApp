namespace ShopApp.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Sukienki" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Spodnie" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Buty" });

            //seed products

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Sukienka 1",
                Price = 124.95M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 1,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka1.png",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka1.png",
                Details = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Spodnie 1",
                Price = 518.95M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 2,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/spodnie1.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gotoit.pl/wp-content/uploads/2021/06/spodnie1.png",
                Details = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Spodnie 2",
                Price = 718.95M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 2,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/spodnie2.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/spodnie2.png",
                Details = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Sukienka 2",
                Price = 155.95M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 1,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka2.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka2.png",
                Details = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Buty 1",
                Price = 103.95M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 3,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty1.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gotoit.pl/wp-content/uploads/2021/06/buty1.png",
                Details = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Buty 2",
                Price = 177.95M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 3,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty2.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty2.png",
                Details = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Sukienka 3",
                Price = 15.90M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 1,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka3.png",
                InStock = false,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka3.png",
                Details = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Buty 3",
                Price = 192.95M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 3,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty3.png",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty3.png",
                Details = ""
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Sukienka 4",
                Price = 1205.95M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 1,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka4.png",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka4.png",
                Details = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Sukienka 5",
                Price = 105.95M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 1,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka5.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka5.png",
                Details = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Spodnie 3",
                Price = 1800.95M,
                ShortDescription = "Krótki opis pobrany z bazy danych",
                LongDescription = "Długi opis pobrany z bazy danych",
                CategoryId = 2,
                ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/spodnie3.png",
                InStock = false,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gotoit.pl/wp-content/uploads/2021/06/spodnie3.png",
                Details = ""
            });
        }
    }
}
