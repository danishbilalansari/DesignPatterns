using DesignPatterns.Behavioral.State.Context;
using DesignPatterns.Behavioral.State.States;

namespace DesignPatterns.Tests.Behavioral;

/// <summary>
/// StateTests class. Contains tests for the State design pattern implementation.
/// </summary>
public class StateTests : BaseTest
{
    /// <summary>
    /// Verifies that setting the state to StartState executes the correct behavior.
    /// </summary>
    [Fact]
    public void SetState_To_StartState_Should_Execute_StartState_Behavior()
    {
        // Arrange: Set up the context and state
        var context = new Context();
        var startState = new StartState();
        var expected = "System is in start state";
        
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: Set the state to StartState
            context.SetState(startState);

            // Assert: The output should indicate the system is in start state
            sw.Flush();
            Assert.Contains(expected, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    /// <summary>
    /// Verifies that setting the state to StopState executes the correct behavior.
    /// </summary>
    [Fact]
    public void SetState_To_StopState_Should_Execute_StopState_Behavior()
    {
        // Arrange: Set up the context and state
        var context = new Context();
        var stopState = new StopState();
        var expected = "System is in stop state";

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: Set the state to StopState
            context.SetState(stopState);

            // Assert: The output should indicate the system is in stop state
            sw.Flush();
            Assert.Contains(expected, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 