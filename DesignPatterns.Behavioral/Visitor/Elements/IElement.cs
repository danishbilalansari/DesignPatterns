namespace DesignPatterns.Behavioral.Visitor.Elements;

using DesignPatterns.Behavioral.Visitor.Visitors;

/// <summary>
/// IElement interface. Represents an element that can accept a visitor.
/// </summary>
public interface IElement
{
    /// <summary>
    /// Accepts a visitor.
    /// </summary>
    /// <param name="visitor">The visitor to accept.</param>
    void Accept(IVisitor visitor);
}
