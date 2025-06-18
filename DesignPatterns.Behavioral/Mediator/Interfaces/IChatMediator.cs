namespace DesignPatterns.Behavioral.Mediator.Interfaces;

public interface IChatMediator
{
    void SendMessage(string message, IUser user);
    void AddUser(IUser user);
}
