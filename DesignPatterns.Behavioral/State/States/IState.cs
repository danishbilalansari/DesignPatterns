namespace DesignPatterns.Behavioral.State.States;

/// <summary>
/// IState interface. Represents a state in the state pattern.
/// </summary>
public interface IState
{
    /// <summary>
    /// Handles the state-specific behavior.
    /// </summary>
    void Handle();
}
