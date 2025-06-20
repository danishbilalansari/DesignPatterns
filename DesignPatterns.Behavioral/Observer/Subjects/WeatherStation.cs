using DesignPatterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Behavioral.Observer.Subjects;

/// <summary>
/// WeatherStation class. Subject that notifies observers of temperature changes.
/// </summary>
public class WeatherStation : ISubject
{
    private List<IObserver> _observers = new();
    private float _temperature;

    /// <summary>
    /// Sets the temperature and notifies observers.
    /// </summary>
    /// <param name="temp">The new temperature.</param>
    public void SetTemperature(float temp)
    {
        _temperature = temp;
        Notify();
    }

    /// <summary>
    /// Registers an observer.
    /// </summary>
    /// <param name="observer">The observer to register.</param>
    public void Register(IObserver observer) => _observers.Add(observer);

    /// <summary>
    /// Unregisters an observer.
    /// </summary>
    /// <param name="observer">The observer to unregister.</param>
    public void Unregister(IObserver observer) => _observers.Remove(observer);

    /// <summary>
    /// Notifies all registered observers of the temperature change.
    /// </summary>
    public void Notify()
    {
        foreach (var observer in _observers)
            observer.Update(_temperature);
    }
}
