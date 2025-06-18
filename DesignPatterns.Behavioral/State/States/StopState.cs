namespace DesignPatterns.Behavioral.State.States;

public class StopState : IState
{
    public void Handle() => Console.WriteLine("System is in stop state");
}
