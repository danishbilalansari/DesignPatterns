using DesignPatterns.Behavioral.Command.Interfaces;
using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Behavioral.Command.Commands;

public class LightOffCommand : ICommand
{
    private readonly Light _light;
    public LightOffCommand(Light light) => _light = light;
    public void Execute() => _light.Off();
}
