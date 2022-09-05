namespace SimpleApp.Models;

/// <summary>
/// An interface for returning a collection of products.
/// </summary>
public interface IDataSource
{
    /// <value>A collection of products.</value>
    IEnumerable<Product> Products { get; }
}
