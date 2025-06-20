using DesignPatterns.Structural.Decorator.Components;

namespace DesignPatterns.Structural.Decorator.Decorators;

/// <summary>
/// SMSDecorator class. Decorator for sending SMS notifications.
/// </summary>
public class SMSDecorator : INotifier
{
    private readonly INotifier _notifier;

    /// <summary>
    /// Initializes a new instance of SMSDecorator.
    /// </summary>
    /// <param name="notifier">The notifier to decorate.</param>
    public SMSDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    /// <summary>
    /// Sends a notification message and an SMS.
    /// </summary>
    /// <param name="message">The message to send.</param>
    public void Send(string message)
    {
        _notifier.Send(message);
        Console.WriteLine("SMS sent: " + message);
    }
}