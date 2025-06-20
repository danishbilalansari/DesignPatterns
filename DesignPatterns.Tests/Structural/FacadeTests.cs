using DesignPatterns.Structural.Facade.Facade;

namespace DesignPatterns.Tests.Structural;

public class FacadeTests : BaseTest
{
    [Fact]
    public void PlayMedia_Should_Call_Audio_And_Video_Subsystems()
    {
        // Arrange
        var facade = new MediaFacade();
        
        var expectedLines = new[]
        {
            "Playing video...",
            "Playing audio..."
        };

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);
        
        try
        {
            // Act
            facade.PlayMedia();

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