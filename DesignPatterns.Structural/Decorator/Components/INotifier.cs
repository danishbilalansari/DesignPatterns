namespace DesignPatterns.Structural.Decorator.Components;

/// <summary>
/// INotifier interface. Represents a notification component.
/// </summary>
public interface INotifier
{
    /// <summary>
    /// Sends a notification message.
    /// </summary>
    /// <param name="message">The message to send.</param>
    void Send(string message);
}