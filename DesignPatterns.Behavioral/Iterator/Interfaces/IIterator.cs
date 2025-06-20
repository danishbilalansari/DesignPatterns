namespace DesignPatterns.Behavioral.Iterator.Interfaces;

/// <summary>
/// IIterator interface. Represents an iterator for a collection.
/// </summary>
public interface IIterator<T>
{
    /// <summary>
    /// Checks if there are more elements in the collection.
    /// </summary>
    /// <returns>True if there are more elements; otherwise, false.</returns>
    bool HasNext();
    /// <summary>
    /// Gets the next element in the collection.
    /// </summary>
    /// <returns>The next element.</returns>
    T Next();
}
