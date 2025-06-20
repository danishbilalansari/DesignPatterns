using DesignPatterns.Behavioral.Mediator.Interfaces;

namespace DesignPatterns.Behavioral.Mediator.Concrete;

/// <summary>
/// User class. Concrete colleague in the mediator pattern.
/// </summary>
public class User : IUser
{
    private readonly string _name;
    private readonly IChatMediator _mediator;

    /// <summary>
    /// Initializes a new instance of User.
    /// </summary>
    /// <param name="name">The user's name.</param>
    /// <param name="mediator">The chat mediator.</param>
    public User(string name, IChatMediator mediator)
    {
        _name = name;
        _mediator = mediator;
    }

    /// <summary>
    /// Sends a message via the mediator.
    /// </summary>
    /// <param name="message">The message to send.</param>
    public void Send(string message)
    {
        Console.WriteLine($"{_name} sends: {message}");
        _mediator.SendMessage(message, this);
    }

    /// <summary>
    /// Receives a message from the mediator.
    /// </summary>
    /// <param name="message">The message received.</param>
    public void Receive(string message) => Console.WriteLine($"{_name} receives: {message}");
}
