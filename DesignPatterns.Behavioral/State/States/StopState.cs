namespace DesignPatterns.Behavioral.State.States;

/// <summary>
/// StopState class. Represents the stop state.
/// </summary>
public class StopState : IState
{
    /// <summary>
    /// Handles the stop state behavior.
    /// </summary>
    public void Handle() => Console.WriteLine("System is in stop state");
}
