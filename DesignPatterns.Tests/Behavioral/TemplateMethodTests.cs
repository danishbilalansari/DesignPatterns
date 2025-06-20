using DesignPatterns.Behavioral.TemplateMethod.Abstract;
using DesignPatterns.Behavioral.TemplateMethod.Concrete;

namespace DesignPatterns.Tests.Behavioral;

/// <summary>
/// TemplateMethodTests class. Contains tests for the Template Method design pattern implementation.
/// </summary>
public class TemplateMethodTests : BaseTest
{
    /// <summary>
    /// Verifies that the Chess game follows the correct sequence of operations.
    /// </summary>
    [Fact]
    public void Play_Should_Follow_Correct_Sequence_For_Chess()
    {
        // Arrange: Create a Chess game
        Game chess = new Chess();
        var expectedLines = new[]
        {
            "Chess Game Initialized!",
            "Chess Game Started!",
            "Chess Game Finished!"
        };
        
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: Play the game
            chess.Play();

            // Assert: The output should follow the correct sequence
            sw.Flush();
            var output = sw.ToString();
            foreach (var line in expectedLines)
            {
                Assert.Contains(line, output);
            }
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    /// <summary>
    /// Verifies that the Football game follows the correct sequence of operations.
    /// </summary>
    [Fact]
    public void Play_Should_Follow_Correct_Sequence_For_Football()
    {
        // Arrange: Create a Football game
        Game football = new Football();
        var expectedLines = new[]
        {
            "Football Game Initialized!",
            "Football Game Started!",
            "Football Game Finished!"
        };

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: Play the game
            football.Play();

            // Assert: The output should follow the correct sequence
            sw.Flush();
            var output = sw.ToString();
            foreach (var line in expectedLines)
            {
                Assert.Contains(line, output);
            }
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 