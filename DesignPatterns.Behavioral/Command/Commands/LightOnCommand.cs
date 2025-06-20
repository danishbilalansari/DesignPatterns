using DesignPatterns.Behavioral.Command.Interfaces;
using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Behavioral.Command.Commands;

/// <summary>
/// LightOnCommand class. Command to turn the light on.
/// </summary>
public class LightOnCommand : ICommand
{
    private readonly Light _light;

    /// <summary>
    /// Initializes a new instance of LightOnCommand.
    /// </summary>
    /// <param name="light">The light receiver.</param>
    public LightOnCommand(Light light) => _light = light;

    /// <summary>
    /// Executes the command to turn the light on.
    /// </summary>
    public void Execute() => _light.On();
}
