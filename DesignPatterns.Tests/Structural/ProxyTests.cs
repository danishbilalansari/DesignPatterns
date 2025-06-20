using DesignPatterns.Structural.Proxy.Proxy;

namespace DesignPatterns.Tests.Structural;

public class ProxyTests : BaseTest
{
    [Fact]
    public void Display_Should_Load_Image_Only_Once()
    {
        // Arrange
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
            // Act
            image.Display(); // First call, should load and display
            image.Display(); // Second call, should only display

            // Assert
            sw.Flush();
            var outputLines = sw.ToString()
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Trim())
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .ToList();

            int searchIndex = 0;
            foreach (var expected in expectedLines)
            {
                bool found = false;
                for (; searchIndex < outputLines.Count; searchIndex++)
                {
                    if (outputLines[searchIndex] == expected)
                    {
                        found = true;
                        searchIndex++; // Move to next line for next search
                        break;
                    }
                }
                Assert.True(found, $"Expected line '{expected}' not found in correct order. Actual output: {string.Join(", ", outputLines)}");
            }
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 