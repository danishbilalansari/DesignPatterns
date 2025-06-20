using DesignPatterns.Behavioral.State.Context;
using DesignPatterns.Behavioral.State.States;

namespace DesignPatterns.Tests.Behavioral;

public class StateTests : BaseTest
{
    [Fact]
    public void SetState_To_StartState_Should_Execute_StartState_Behavior()
    {
        // Arrange
        var context = new Context();
        var startState = new StartState();
        var expected = "System is in start state";
        
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act
            context.SetState(startState);

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
    public void SetState_To_StopState_Should_Execute_StopState_Behavior()
    {
        // Arrange
        var context = new Context();
        var stopState = new StopState();
        var expected = "System is in stop state";

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act
            context.SetState(stopState);

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