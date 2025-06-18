namespace DesignPatterns.Behavioral.Visitor.Visitors;

using DesignPatterns.Behavioral.Visitor.Elements;

public class PriceCalculatorVisitor : IVisitor
{
    public double Total { get; private set; }

    public void Visit(Book book)
    {
        Console.WriteLine($"Book: {book.Title}, Price: {book.Price}");
        Total += book.Price;
    }

    public void Visit(Fruit fruit)
    {
        double cost = fruit.Weight * fruit.PricePerKg;
        Console.WriteLine($"Fruit: {fruit.Name}, Cost: {cost}");
        Total += cost;
    }
}
