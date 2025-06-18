namespace DesignPatterns.Behavioral.Visitor.Elements;

using DesignPatterns.Behavioral.Visitor.Visitors;

public class Fruit : IElement
{
    public string Name { get; }
    public double Weight { get; }
    public double PricePerKg { get; }

    public Fruit(string name, double weight, double pricePerKg)
    {
        Name = name;
        Weight = weight;
        PricePerKg = pricePerKg;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
