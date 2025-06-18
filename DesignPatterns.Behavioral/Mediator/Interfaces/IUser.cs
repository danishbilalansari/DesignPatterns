namespace DesignPatterns.Behavioral.Mediator.Interfaces;

public interface IUser
{
    void Send(string message);
    void Receive(string message);
}
