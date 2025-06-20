using DesignPatterns.Behavioral.Command.Interfaces;
using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Behavioral.Command.Commands;

/// <summary>
/// LightOffCommand class. Command to turn the light off.
/// </summary>
public class LightOffCommand : ICommand
{
    private readonly Light _light;

    /// <summary>
    /// Initializes a new instance of LightOffCommand.
    /// </summary>
    /// <param name="light">The light receiver.</param>
    public LightOffCommand(Light light) => _light = light;

    /// <summary>
    /// Executes the command to turn the light off.
    /// </summary>
    public void Execute() => _light.Off();
}
