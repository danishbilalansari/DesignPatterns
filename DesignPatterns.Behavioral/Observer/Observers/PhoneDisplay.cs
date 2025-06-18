using DesignPatterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Behavioral.Observer.Observers;

public class PhoneDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Phone Display: Current temperature is {temperature}°C");
    }
}
