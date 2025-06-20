namespace DesignPatterns.Behavioral.Iterator.Interfaces;

/// <summary>
/// IAggregate interface. Represents a collection that can be iterated.
/// </summary>
public interface IAggregate<T>
{
    /// <summary>
    /// Creates an iterator for the collection.
    /// </summary>
    /// <returns>An iterator for the collection.</returns>
    IIterator<T> CreateIterator();
}
