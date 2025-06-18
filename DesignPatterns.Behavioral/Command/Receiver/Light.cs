namespace DesignPatterns.Behavioral.Command.Receiver;

public class Light
{
    public void On() => Console.WriteLine("Light is ON");
    public void Off() => Console.WriteLine("Light is OFF");
}
