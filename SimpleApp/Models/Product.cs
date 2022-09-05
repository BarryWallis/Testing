namespace SimpleApp.Models;

/// <summary>
/// A simple product.
/// </summary>
/// <param name="Name">The product name.</param>
/// <param name="Price">The product price.</param>
public record Product(string Name, decimal? Price)
{
    /// <summary>
    /// Get a sample list of products.
    /// </summary>
    /// <returns>The sample list of products.</returns>
    public static Product[] GetProducts() => new Product[] { new("Kayak", 275.00M), new("Lifejacket", 48.95M) };
}
