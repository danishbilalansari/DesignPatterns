namespace DesignPatterns.Creational.Prototype.Models;

/// <summary>
/// ConcreteProduct class. Implements cloning for a specific product.
/// </summary>
public class ConcreteProduct : Product
{
    public string Category { get; set; }

    /// <summary>
    /// Initializes a new instance of ConcreteProduct.
    /// </summary>
    /// <param name="name">Product name.</param>
    /// <param name="category">Product category.</param>
    public ConcreteProduct(string name, string category)
    {
        Name = name;
        Category = category;
    }

    /// <summary>
    /// Creates a clone of the concrete product.
    /// </summary>
    /// <returns>A new Product instance.</returns>
    public override Product Clone()
    {
        // Perform a shallow copy (can be replaced with deep copy if needed)
        return (Product)this.MemberwiseClone();
    }

    /// <summary>
    /// Shows the product category.
    /// </summary>
    public void ShowCategory()
    {
        Console.WriteLine($"Category: {Category}");
    }
}