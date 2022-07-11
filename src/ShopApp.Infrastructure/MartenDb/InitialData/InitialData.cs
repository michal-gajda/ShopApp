namespace ShopApp.Infrastructure.MartenDb.InitialData;

using Marten;
using Marten.Schema;
using ShopApp.Domain.Entities;

internal sealed class InitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellationToken = default)
    {
        using var session = store.LightweightSession();

        PopulateBootsCategoryWithProducts(session);
        PopulateDressCategoryWithProducts(session);
        PopulateTrousersCategoryWithProducts(session);

        await session.SaveChangesAsync(cancellationToken);
    }

    private static void PopulateBootsCategoryWithProducts(IDocumentSession session)
    {
        var category = new CategoryEntity(Guid.NewGuid())
        {
            Name = "Buty",
        };

        session.Store(category);

        var bootsOne = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = Guid.NewGuid(),
            ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty1.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty1.png",
            InStock = true,
            IsProductOfTheWeek = false,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Buty 1",
            Price = 103.95M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(bootsOne);

        var bootsTwo = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = category.Id,
            ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty2.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty2.png",
            InStock = true,
            IsProductOfTheWeek = false,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Buty 2",
            Price = 177.95M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(bootsTwo);

        var bootsThree = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = category.Id,
            ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty3.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/buty3.png",
            InStock = true,
            IsProductOfTheWeek = true,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Buty 3",
            Price = 192.95M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(bootsThree);
    }

    private static void PopulateDressCategoryWithProducts(IDocumentSession session)
    {
        var category = new CategoryEntity(Guid.NewGuid())
        {
            Name = "Sukienki",
        };

        session.Store(category);

        var dressOne = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = category.Id,
            InStock = true,
            ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka1.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka1.png",
            IsProductOfTheWeek = true,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Sukienka 1",
            Price = 124.95M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(dressOne);

        var dressTwo = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = category.Id,
            ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka2.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka2.png",
            InStock = true,
            IsProductOfTheWeek = false,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Sukienka 2",
            Price = 155.95M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(dressTwo);

        var dressThree = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = category.Id,
            ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka3.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka3.png",
            InStock = false,
            IsProductOfTheWeek = false,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Sukienka 3",
            Price = 15.90M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(dressThree);

        var dressFour = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = category.Id,
            ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka4.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka4.png",
            InStock = true,
            IsProductOfTheWeek = true,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Sukienka 4",
            Price = 1205.95M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(dressFour);

        var dressFive = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = category.Id,
            ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka5.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/sukienka5.png",
            InStock = true,
            IsProductOfTheWeek = false,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Sukienka 5",
            Price = 105.95M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(dressFive);
    }

    private static void PopulateTrousersCategoryWithProducts(IDocumentSession session)
    {
        var category = new CategoryEntity(Guid.NewGuid())
        {
            Name = "Spodnie",
        };

        session.Store(category);

        var trousersOne = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = category.Id,
            ImageThumbnailUrl =
                "https://gotoit.pl/wp-content/uploads/2021/06/spodnie1.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/spodnie1.png",
            InStock = true,
            IsProductOfTheWeek = false,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Spodnie 1",
            Price = 518.95M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(trousersOne);

        var trousersTwo = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = category.Id,
            ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/spodnie2.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/spodnie2.png",
            InStock = true,
            IsProductOfTheWeek = false,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Spodnie 2",
            Price = 718.95M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(trousersTwo);

        var trousersThree = new ProductEntity(Guid.NewGuid())
        {
            CategoryId = category.Id,
            ImageThumbnailUrl = "https://gotoit.pl/wp-content/uploads/2021/06/spodnie3.png",
            ImageUrl = "https://gotoit.pl/wp-content/uploads/2021/06/spodnie3.png",
            InStock = false,
            IsProductOfTheWeek = false,
            LongDescription = "Długi opis pobrany z bazy danych",
            Name = "Spodnie 3",
            Price = 1800.95M,
            ShortDescription = "Krótki opis pobrany z bazy danych",
        };

        session.Store(trousersThree);
    }
}
