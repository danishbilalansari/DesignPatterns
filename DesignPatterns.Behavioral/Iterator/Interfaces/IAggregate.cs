namespace DesignPatterns.Behavioral.Iterator.Interfaces;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}
