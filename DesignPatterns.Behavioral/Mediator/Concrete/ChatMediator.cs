using DesignPatterns.Behavioral.Mediator.Interfaces;

namespace DesignPatterns.Behavioral.Mediator.Concrete;

/// <summary>
/// ChatMediator class. Concrete mediator for user communication.
/// </summary>
public class ChatMediator : IChatMediator
{
    private readonly List<IUser> _users = new();

    /// <summary>
    /// Adds a user to the chat.
    /// </summary>
    /// <param name="user">The user to add.</param>
    public void AddUser(IUser user) => _users.Add(user);

    /// <summary>
    /// Sends a message from the sender to all other users.
    /// </summary>
    /// <param name="message">The message to send.</param>
    /// <param name="sender">The user sending the message.</param>
    public void SendMessage(string message, IUser sender)
    {
        foreach (var user in _users)
        {
            if (user != sender)
                user.Receive(message);
        }
    }
}
