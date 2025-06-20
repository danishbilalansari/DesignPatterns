namespace DesignPatterns.Behavioral.Visitor.Elements;

using DesignPatterns.Behavioral.Visitor.Visitors;

/// <summary>
/// Book class. Concrete element in the visitor pattern.
/// </summary>
public class Book : IElement
{
    /// <summary>
    /// Initializes a new instance of Book.
    /// </summary>
    /// <param name="title">The title of the book.</param>
    /// <param name="price">The price of the book.</param>
    public Book(string title, double price)
    {
        Title = title;
        Price = price;
    }

    /// <summary>
    /// Accepts a visitor.
    /// </summary>
    /// <param name="visitor">The visitor to accept.</param>
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string Title { get; }
    public double Price { get; }
}
