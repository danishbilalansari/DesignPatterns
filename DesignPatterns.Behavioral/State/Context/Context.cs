using DesignPatterns.Behavioral.State.States;

namespace DesignPatterns.Behavioral.State.Context;

public class Context
{
    private IState _state = null!;

    public void SetState(IState state)
    {
        _state = state;
        _state.Handle();
    }
}
