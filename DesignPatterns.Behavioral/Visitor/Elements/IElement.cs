namespace DesignPatterns.Behavioral.Visitor.Elements;

using DesignPatterns.Behavioral.Visitor.Visitors;

public interface IElement
{
    void Accept(IVisitor visitor);
}
