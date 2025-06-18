namespace DesignPatterns.Behavioral.State.States;

public class StartState : IState
{
    public void Handle() => Console.WriteLine("System is in start state");
}
