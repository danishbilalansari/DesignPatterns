namespace DesignPatterns.Behavioral.Mediator.Interfaces;

/// <summary>
/// IChatMediator interface. Defines mediator operations for chat communication.
/// </summary>
public interface IChatMediator
{
    /// <summary>
    /// Sends a message from a user to others.
    /// </summary>
    /// <param name="message">The message to send.</param>
    /// <param name="user">The user sending the message.</param>
    void SendMessage(string message, IUser user);
    /// <summary>
    /// Adds a user to the chat.
    /// </summary>
    /// <param name="user">The user to add.</param>
    void AddUser(IUser user);
}
