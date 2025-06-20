using DesignPatterns.Behavioral.TemplateMethod.Abstract;
using DesignPatterns.Behavioral.TemplateMethod.Concrete;

namespace DesignPatterns.Tests.Behavioral;

public class TemplateMethodTests : BaseTest
{
    [Fact]
    public void Play_Should_Follow_Correct_Sequence_For_Chess()
    {
        // Arrange
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
            // Act
            chess.Play();

            // Assert
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

    [Fact]
    public void Play_Should_Follow_Correct_Sequence_For_Football()
    {
        // Arrange
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
            // Act
            football.Play();

            // Assert
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