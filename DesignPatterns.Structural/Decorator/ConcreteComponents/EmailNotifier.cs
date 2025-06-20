using DesignPatterns.Structural.Decorator.Components;

namespace DesignPatterns.Structural.Decorator.ConcreteComponents;

/// <summary>
/// EmailNotifier class. Concrete component for sending email notifications.
/// </summary>
public class EmailNotifier : INotifier
{
    /// <summary>
    /// Sends an email notification message.
    /// </summary>
    /// <param name="message">The message to send.</param>
    public void Send(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}