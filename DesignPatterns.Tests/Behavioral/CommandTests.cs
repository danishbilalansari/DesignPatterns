using DesignPatterns.Behavioral.Command.Commands;
using DesignPatterns.Behavioral.Command.Invoker;
using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Tests.Behavioral;

public class CommandTests : BaseTest
{
    [Fact]
    public void PressButton_Should_Execute_LightOnCommand()
    {
        // Arrange
        var light = new Light();
        var lightOnCommand = new LightOnCommand(light);
        var remote = new RemoteControl();
        remote.SetCommand(lightOnCommand);
        
        var expected = "Light is ON";
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act
            remote.PressButton();

            // Assert
            sw.Flush();
            Assert.Contains(expected, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    [Fact]
    public void PressButton_Should_Execute_LightOffCommand()
    {
        // Arrange
        var light = new Light();
        var lightOffCommand = new LightOffCommand(light);
        var remote = new RemoteControl();
        remote.SetCommand(lightOffCommand);

        var expected = "Light is OFF";
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act
            remote.PressButton();

            // Assert
            sw.Flush();
            Assert.Contains(expected, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 