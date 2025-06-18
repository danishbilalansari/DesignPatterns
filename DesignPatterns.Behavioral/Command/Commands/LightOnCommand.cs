using DesignPatterns.Behavioral.Command.Interfaces;
using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Behavioral.Command.Commands;

public class LightOnCommand : ICommand
{
    private readonly Light _light;
    public LightOnCommand(Light light) => _light = light;
    public void Execute() => _light.On();
}
