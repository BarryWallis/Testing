using SimpleApp.Models;

namespace SimpleApp.Tests;
public class ProductTests
{
    [Fact]
    public void CanChangeProductName()
    {
        Product product = new() { Name = "Test", Price = 100.00M };

        product.Name = "New Name";

        Assert.Equal("New Name", product.Name);
    }

    [Fact]
    public void CanChangeProductPrice()
    {
        Product product = new() { Name = "Test", Price = 100.00M };

        product.Price = 200.00M;

        Assert.Equal(200.00M, product.Price);
    }
}
