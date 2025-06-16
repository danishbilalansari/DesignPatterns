namespace DesignPatterns.Structural.Bridge.Implementations;

public class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing a circle of radius {radius} with raster rendering.");
    }
}