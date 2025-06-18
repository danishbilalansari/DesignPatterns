using DesignPatterns.Behavioral.Iterator.Interfaces;

namespace DesignPatterns.Behavioral.Iterator.Concrete;

public class NameRepository : IAggregate<string>
{
    private readonly string[] _names = { "Alice", "Bob", "Charlie" };

    public IIterator<string> CreateIterator() => new NameIterator(_names);
}
