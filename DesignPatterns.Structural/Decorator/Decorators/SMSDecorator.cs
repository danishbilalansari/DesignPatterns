using DesignPatterns.Structural.Decorator.Components;

namespace DesignPatterns.Structural.Decorator.Decorators;

public class SMSDecorator : INotifier
{
    private readonly INotifier _notifier;

    public SMSDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Send(string message)
    {
        _notifier.Send(message);
        Console.WriteLine("SMS sent: " + message);
    }
}