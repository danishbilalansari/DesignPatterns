using DesignPatterns.Behavioral.Iterator.Interfaces;

namespace DesignPatterns.Behavioral.Iterator.Concrete;

public class NameIterator : IIterator<string>
{
    private readonly string[] _names;
    private int _index;

    public NameIterator(string[] names)
    {
        _names = names;
        _index = 0;
    }

    public bool HasNext() => _index < _names.Length;

    public string Next() => _names[_index++];
}
