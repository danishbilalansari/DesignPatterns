namespace DesignPatterns.Behavioral.State.States;

/// <summary>
/// StartState class. Represents the start state.
/// </summary>
public class StartState : IState
{
    /// <summary>
    /// Handles the start state behavior.
    /// </summary>
    public void Handle() => Console.WriteLine("System is in start state");
}
