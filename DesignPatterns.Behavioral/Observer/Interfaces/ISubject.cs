namespace DesignPatterns.Behavioral.Observer.Interfaces;

/// <summary>
/// ISubject interface. Represents a subject in the observer pattern.
/// </summary>
public interface ISubject
{
    /// <summary>
    /// Registers an observer.
    /// </summary>
    /// <param name="observer">The observer to register.</param>
    void Register(IObserver observer);
    /// <summary>
    /// Unregisters an observer.
    /// </summary>
    /// <param name="observer">The observer to unregister.</param>
    void Unregister(IObserver observer);
    /// <summary>
    /// Notifies all registered observers.
    /// </summary>
    void Notify();
}
