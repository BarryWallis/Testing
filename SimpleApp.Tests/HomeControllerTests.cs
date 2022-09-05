using Moq;

using SimpleApp.Controllers;
using SimpleApp.Models;

namespace SimpleApp.Tests;
public class HomeControllerTests
{
    [Fact]
    public void IndexActionModeIsComplete()
    {
        Product[] testProducts = new Product[]
        {
            new Product { Name = "P1", Price = 75.10M },
            new Product { Name = "P2", Price = 120.00M },
            new Product { Name = "P3", Price = 110.00M },
        };
        Mock<IDataSource> mock = new();
        _ = mock.SetupGet(x => x.Products).Returns(testProducts);
        HomeController homeController = new()
        {
            DataSource = mock.Object
        };

        IEnumerable<Product>? model = homeController.Index()?.ViewData.Model as IEnumerable<Product>;

        Assert.NotNull(model);
        Assert.Equal(testProducts,
                     model,
                     Comparer.Get<Product>((p1, p2)
                        => p1?.Name == p2?.Name && p1?.Price == p2?.Price));
        mock.VerifyGet(ds => ds.Products, Times.Once);
    }
}
