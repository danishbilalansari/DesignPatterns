namespace DesignPatterns.Behavioral.Mediator.Interfaces;

/// <summary>
/// IUser interface. Represents a user in the chat mediator pattern.
/// </summary>
public interface IUser
{
    /// <summary>
    /// Sends a message via the mediator.
    /// </summary>
    /// <param name="message">The message to send.</param>
    void Send(string message);
    /// <summary>
    /// Receives a message from the mediator.
    /// </summary>
    /// <param name="message">The message received.</param>
    void Receive(string message);
}
