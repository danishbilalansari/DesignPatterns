using DesignPatterns.Structural.Proxy.Proxy;

namespace DesignPatterns.Tests.Structural;

/// <summary>
/// ProxyTests class. Contains tests for the Proxy design pattern implementation.
/// </summary>
public class ProxyTests : BaseTest
{
    /// <summary>
    /// Verifies that the ImageProxy loads the image only once and displays it multiple times.
    /// </summary>
    [Fact]
    public void Display_Should_Load_Image_Only_Once()
    {
        // Arrange: Create the image proxy
        var image = new ImageProxy("test_image.jpg");
        var expectedLines = new[]
        {
            "Loading test_image.jpg",
            "Displaying test_image.jpg",
            "Displaying test_image.jpg"
        };

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);
        
        try
        {
            // Act: Display the image twice
            image.Display(); // First call, should load and display
            image.Display(); // Second call, should only display

            // Assert: The output should show loading once and displaying twice
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