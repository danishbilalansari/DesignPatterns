using DesignPatterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Behavioral.Observer.Observers;

/// <summary>
/// PhoneDisplay class. Observer that displays temperature on a phone.
/// </summary>
public class PhoneDisplay : IObserver
{
    /// <summary>
    /// Updates the phone display with the new temperature.
    /// </summary>
    /// <param name="temperature">The updated temperature.</param>
    public void Update(float temperature)
    {
        Console.WriteLine($"Phone Display: Current temperature is {temperature}°C");
    }
}
