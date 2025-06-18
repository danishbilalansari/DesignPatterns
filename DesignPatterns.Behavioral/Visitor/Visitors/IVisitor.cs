namespace DesignPatterns.Behavioral.Visitor.Visitors;

using DesignPatterns.Behavioral.Visitor.Elements;

public interface IVisitor
{
    void Visit(Book book);
    void Visit(Fruit fruit);
}
