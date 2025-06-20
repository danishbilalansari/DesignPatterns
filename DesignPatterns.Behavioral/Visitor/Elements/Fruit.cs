namespace DesignPatterns.Behavioral.Visitor.Elements;

using DesignPatterns.Behavioral.Visitor.Visitors;

/// <summary>
/// Fruit class. Concrete element in the visitor pattern.
/// </summary>
public class Fruit : IElement
{
    /// <summary>
    /// Initializes a new instance of Fruit.
    /// </summary>
    /// <param name="name">The name of the fruit.</param>
    /// <param name="weight">The weight of the fruit.</param>
    /// <param name="pricePerKg">The price per kilogram.</param>
    public Fruit(string name, double weight, double pricePerKg)
    {
        Name = name;
        Weight = weight;
        PricePerKg = pricePerKg;
    }

    /// <summary>
    /// Accepts a visitor.
    /// </summary>
    /// <param name="visitor">The visitor to accept.</param>
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string Name { get; }
    public double Weight { get; }
    public double PricePerKg { get; }
}
