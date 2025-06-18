namespace DesignPatterns.Behavioral.Iterator.Interfaces;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}
