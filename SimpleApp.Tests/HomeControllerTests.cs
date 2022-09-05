using SimpleApp.Controllers;
using SimpleApp.Models;

namespace SimpleApp.Tests;
public class HomeControllerTests
{
    private class FakeDataSource : IDataSource
    {
        public FakeDataSource(Product[] products) => Products = products;

        public IEnumerable<Product> Products { get; init; }
    }

    [Fact]
    public void IndexActionModeIsComplete()
    {
        Product[] testProducts = new Product[]
        {
            new Product { Name = "P1", Price = 75.10M },
            new Product { Name = "P2", Price = 120.00M },
            new Product { Name = "P3", Price = 110.00M },
        };
        IDataSource dataSource = new FakeDataSource(testProducts);
        HomeController homeController = new()
        {
            DataSource = dataSource
        };

        IEnumerable<Product>? model = homeController.Index()?.ViewData.Model as IEnumerable<Product>;

        Assert.Equal(dataSource.Products,
                     model,
                     Comparer.Get<Product>((p1, p2)
                        => p1?.Name == p2?.Name && p1?.Price == p2?.Price));
    }
}
