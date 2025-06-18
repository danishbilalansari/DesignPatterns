using DesignPatterns.Behavioral.Mediator.Interfaces;

namespace DesignPatterns.Behavioral.Mediator.Concrete;

public class User : IUser
{
    private readonly string _name;
    private readonly IChatMediator _mediator;

    public User(string name, IChatMediator mediator)
    {
        _name = name;
        _mediator = mediator;
    }

    public void Send(string message)
    {
        Console.WriteLine($"{_name} sends: {message}");
        _mediator.SendMessage(message, this);
    }

    public void Receive(string message) => Console.WriteLine($"{_name} receives: {message}");
}
