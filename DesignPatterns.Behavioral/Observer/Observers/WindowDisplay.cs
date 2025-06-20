using DesignPatterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Behavioral.Observer.Observers;

/// <summary>
/// WindowDisplay class. Observer that displays temperature on a window.
/// </summary>
public class WindowDisplay : IObserver
{
    /// <summary>
    /// Updates the window display with the new temperature.
    /// </summary>
    /// <param name="temperature">The updated temperature.</param>
    public void Update(float temperature)
    {
        Console.WriteLine($"Window Display: Current temperature is {temperature}°C");
    }
}
