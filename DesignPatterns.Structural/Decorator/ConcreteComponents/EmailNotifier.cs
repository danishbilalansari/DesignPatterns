using DesignPatterns.Structural.Decorator.Components;

namespace DesignPatterns.Structural.Decorator.ConcreteComponents;

public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}