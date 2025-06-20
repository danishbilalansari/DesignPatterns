namespace DesignPatterns.Behavioral.Observer.Interfaces;

/// <summary>
/// IObserver interface. Represents an observer in the observer pattern.
/// </summary>
public interface IObserver
{
    /// <summary>
    /// Updates the observer with the new temperature.
    /// </summary>
    /// <param name="temperature">The updated temperature.</param>
    void Update(float temperature);
}
