using DesignPatterns.Structural.Bridge.Abstractions;
using DesignPatterns.Structural.Bridge.Implementations;

namespace DesignPatterns.Tests.Structural;

public class BridgeTests : BaseTest
{
    [Fact]
    public void Circle_With_VectorRenderer_Should_Draw_Vector_Circle()
    {
        // Arrange
        var renderer = new VectorRenderer();
        var circle = new Circle(renderer, 5);
        var expected = "Drawing a circle of radius 5 with vector rendering.";

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act
            circle.Draw();

            // Assert
            sw.Flush();
            var output = sw.ToString();
            Assert.Contains("Drawing a circle of radius 5", output);
            Assert.Contains("vector rendering", output);
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    [Fact]
    public void Circle_With_RasterRenderer_Should_Draw_Raster_Circle()
    {
        // Arrange
        var renderer = new RasterRenderer();
        var circle = new Circle(renderer, 10);
        var expectedOutput = "Drawing a circle of radius 10 with raster rendering.";

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act
            circle.Draw();

            // Assert
            sw.Flush();
            Assert.Contains(expectedOutput, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 