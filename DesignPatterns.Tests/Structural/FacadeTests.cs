using DesignPatterns.Structural.Facade.Facade;

namespace DesignPatterns.Tests.Structural;

/// <summary>
/// FacadeTests class. Contains tests for the Facade design pattern implementation.
/// </summary>
public class FacadeTests : BaseTest
{
    /// <summary>
    /// Verifies that the MediaFacade calls both audio and video subsystems.
    /// </summary>
    [Fact]
    public void PlayMedia_Should_Call_Audio_And_Video_Subsystems()
    {
        // Arrange: Create the facade
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
            // Act: Play media
            facade.PlayMedia();

            // Assert: The output should include both video and audio messages
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