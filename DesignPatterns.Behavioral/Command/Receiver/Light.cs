namespace DesignPatterns.Behavioral.Command.Receiver;

/// <summary>
/// Light class. Receiver that performs actions for commands.
/// </summary>
public class Light
{
    /// <summary>
    /// Turns the light on.
    /// </summary>
    public void On() => Console.WriteLine("Light is ON");
    /// <summary>
    /// Turns the light off.
    /// </summary>
    public void Off() => Console.WriteLine("Light is OFF");
}
