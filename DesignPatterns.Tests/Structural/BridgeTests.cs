using DesignPatterns.Structural.Bridge.Abstractions;
using DesignPatterns.Structural.Bridge.Implementations;

namespace DesignPatterns.Tests.Structural;

/// <summary>
/// BridgeTests class. Contains tests for the Bridge design pattern implementation.
/// </summary>
public class BridgeTests : BaseTest
{
    /// <summary>
    /// Verifies that a Circle rendered with VectorRenderer produces the correct output.
    /// </summary>
    [Fact]
    public void Circle_With_VectorRenderer_Should_Draw_Vector_Circle()
    {
        // Arrange: Create a circle with a vector renderer
        var renderer = new VectorRenderer();
        var circle = new Circle(renderer, 5);
        var expectedOutput = "Drawing a circle of radius 5 with vector rendering.";

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: Draw the circle
            circle.Draw();

            // Assert: The output should indicate vector rendering
            sw.Flush();
            Assert.Contains(expectedOutput, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    /// <summary>
    /// Verifies that a Circle rendered with RasterRenderer produces the correct output.
    /// </summary>
    [Fact]
    public void Circle_With_RasterRenderer_Should_Draw_Raster_Circle()
    {
        // Arrange: Create a circle with a raster renderer
        var renderer = new RasterRenderer();
        var circle = new Circle(renderer, 10);
        var expectedOutput = "Drawing a circle of radius 10 with raster rendering.";

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: Draw the circle
            circle.Draw();

            // Assert: The output should indicate raster rendering
            sw.Flush();
            Assert.Contains(expectedOutput, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 