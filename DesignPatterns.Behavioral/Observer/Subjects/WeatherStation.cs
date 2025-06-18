using DesignPatterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Behavioral.Observer.Subjects;

public class WeatherStation : ISubject
{
    private List<IObserver> _observers = new();
    private float _temperature;

    public void SetTemperature(float temp)
    {
        _temperature = temp;
        Notify();
    }

    public void Register(IObserver observer) => _observers.Add(observer);

    public void Unregister(IObserver observer) => _observers.Remove(observer);

    public void Notify()
    {
        foreach (var observer in _observers)
            observer.Update(_temperature);
    }
}
