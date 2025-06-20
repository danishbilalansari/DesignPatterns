using DesignPatterns.Behavioral.Command.Commands;
using DesignPatterns.Behavioral.Command.Invoker;
using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Tests.Behavioral;

/// <summary>
/// CommandTests class. Contains tests for the Command design pattern implementation.
/// </summary>
public class CommandTests : BaseTest
{
    /// <summary>
    /// Verifies that pressing the button executes the LightOnCommand and turns the light on.
    /// </summary>
    [Fact]
    public void PressButton_Should_Execute_LightOnCommand()
    {
        // Arrange: Set up the light, command, and remote control
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
            // Act: Press the button
            remote.PressButton();

            // Assert: The output should indicate the light is on
            sw.Flush();
            Assert.Contains(expected, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    /// <summary>
    /// Verifies that pressing the button executes the LightOffCommand and turns the light off.
    /// </summary>
    [Fact]
    public void PressButton_Should_Execute_LightOffCommand()
    {
        // Arrange: Set up the light, command, and remote control
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
            // Act: Press the button
            remote.PressButton();

            // Assert: The output should indicate the light is off
            sw.Flush();
            Assert.Contains(expected, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 