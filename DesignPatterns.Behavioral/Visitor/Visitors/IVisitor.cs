namespace DesignPatterns.Behavioral.Visitor.Visitors;

using DesignPatterns.Behavioral.Visitor.Elements;

/// <summary>
/// IVisitor interface. Represents a visitor for elements.
/// </summary>
public interface IVisitor
{
    /// <summary>
    /// Visits a book element.
    /// </summary>
    /// <param name="book">The book to visit.</param>
    void Visit(Book book);
    /// <summary>
    /// Visits a fruit element.
    /// </summary>
    /// <param name="fruit">The fruit to visit.</param>
    void Visit(Fruit fruit);
}
