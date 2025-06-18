using DesignPatterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Behavioral.Observer.Observers;

public class WindowDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Window Display: Current temperature is {temperature}°C");
    }
}
