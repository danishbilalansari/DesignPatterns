using DesignPatterns.Behavioral.Iterator.Interfaces;

namespace DesignPatterns.Behavioral.Iterator.Concrete;

/// <summary>
/// NameRepository class. Concrete aggregate for names.
/// </summary>
public class NameRepository : IAggregate<string>
{
    private readonly string[] _names = { "Alice", "Bob", "Charlie" };

    /// <summary>
    /// Creates an iterator for the names collection.
    /// </summary>
    /// <returns>An iterator for the names.</returns>
    public IIterator<string> CreateIterator() => new NameIterator(_names);
}
