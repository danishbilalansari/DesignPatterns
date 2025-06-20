using DesignPatterns.Behavioral.Iterator.Interfaces;

namespace DesignPatterns.Behavioral.Iterator.Concrete;

/// <summary>
/// NameIterator class. Concrete iterator for names.
/// </summary>
public class NameIterator : IIterator<string>
{
    private readonly string[] _names;
    private int _index;

    /// <summary>
    /// Initializes a new instance of NameIterator.
    /// </summary>
    /// <param name="names">The array of names to iterate.</param>
    public NameIterator(string[] names)
    {
        _names = names;
        _index = 0;
    }

    /// <summary>
    /// Checks if there are more names to iterate.
    /// </summary>
    /// <returns>True if there are more names; otherwise, false.</returns>
    public bool HasNext() => _index < _names.Length;

    /// <summary>
    /// Gets the next name in the iteration.
    /// </summary>
    /// <returns>The next name.</returns>
    public string Next() => _names[_index++];
}
