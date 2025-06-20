using DesignPatterns.Behavioral.State.States;

namespace DesignPatterns.Behavioral.State.Context;

/// <summary>
/// Context class. Maintains a reference to a state object.
/// </summary>
public class Context
{
    private IState _state = null!;

    /// <summary>
    /// Sets the current state and calls its Handle method.
    /// </summary>
    /// <param name="state">The state to set.</param>
    public void SetState(IState state)
    {
        _state = state;
        _state.Handle();
    }
}
