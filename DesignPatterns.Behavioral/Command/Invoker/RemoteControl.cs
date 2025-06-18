using DesignPatterns.Behavioral.Command.Interfaces;

namespace DesignPatterns.Behavioral.Command.Invoker;

public class RemoteControl
{
    private ICommand _command;

    public void SetCommand(ICommand command) => _command = command;

    public void PressButton() => _command.Execute();
}
