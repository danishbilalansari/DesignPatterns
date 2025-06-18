using DesignPatterns.Behavioral.Mediator.Interfaces;

namespace DesignPatterns.Behavioral.Mediator.Concrete;

public class ChatMediator : IChatMediator
{
    private readonly List<IUser> _users = new();

    public void AddUser(IUser user) => _users.Add(user);

    public void SendMessage(string message, IUser sender)
    {
        foreach (var user in _users)
        {
            if (user != sender)
                user.Receive(message);
        }
    }
}
