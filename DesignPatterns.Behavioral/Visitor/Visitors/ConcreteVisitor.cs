namespace DesignPatterns.Behavioral.Visitor.Visitors;

using DesignPatterns.Behavioral.Visitor.Elements;

/// <summary>
/// PriceCalculatorVisitor class. Concrete visitor that calculates total price.
/// </summary>
public class PriceCalculatorVisitor : IVisitor
{
    public double Total { get; private set; }

    /// <summary>
    /// Visits a book and adds its price to the total.
    /// </summary>
    /// <param name="book">The book to visit.</param>
    public void Visit(Book book)
    {
        Console.WriteLine($"Book: {book.Title}, Price: {book.Price}");
        Total += book.Price;
    }

    /// <summary>
    /// Visits a fruit and adds its cost to the total.
    /// </summary>
    /// <param name="fruit">The fruit to visit.</param>
    public void Visit(Fruit fruit)
    {
        double cost = fruit.Weight * fruit.PricePerKg;
        Console.WriteLine($"Fruit: {fruit.Name}, Cost: {cost}");
        Total += cost;
    }
}
