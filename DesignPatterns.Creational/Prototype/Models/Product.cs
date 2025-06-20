namespace DesignPatterns.Creational.Prototype.Models;

/// <summary>
/// Product abstract class. Serves as the prototype for cloning.
/// </summary>
public abstract class Product
{
    public string Name { get; set; }

    /// <summary>
    /// Creates a clone of the product.
    /// </summary>
    /// <returns>A new Product instance.</returns>
    public abstract Product Clone();

    /// <summary>
    /// Shows product details.
    /// </summary>
    public void ShowDetails()
    {
        Console.WriteLine($"Product: {Name}");
    }
}