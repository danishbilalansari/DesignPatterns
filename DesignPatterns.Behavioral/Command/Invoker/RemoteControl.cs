using DesignPatterns.Behavioral.Command.Interfaces;

namespace DesignPatterns.Behavioral.Command.Invoker;

/// <summary>
/// RemoteControl class. Invoker that executes commands.
/// </summary>
public class RemoteControl
{
    private ICommand _command;

    /// <summary>
    /// Sets the command to be executed.
    /// </summary>
    /// <param name="command">The command to set.</param>
    public void SetCommand(ICommand command) => _command = command;

    /// <summary>
    /// Executes the set command.
    /// </summary>
    public void PressButton() => _command.Execute();
}
