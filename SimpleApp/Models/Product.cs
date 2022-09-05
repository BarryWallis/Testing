namespace SimpleApp.Models;

/// <summary>
/// A simple product.
/// </summary>
/// <param name="Name">The product name.</param>
/// <param name="Price">The product price.</param>
public class Product
{
    /// <value>The product name.</value>
    public string Name { get; set; } = string.Empty;

    /// <value>The product price.</value>
    public decimal? Price { get; set; }
}

public class ProductDataSource : IDataSource
{
    public IEnumerable<Product> Products => new Product[]
        {
            new Product { Name = "Kayak", Price = 275M },
            new Product { Name = "Lifejacket", Price = 48.95M }
        };
}
