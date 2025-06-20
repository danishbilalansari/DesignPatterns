namespace DesignPatterns.Structural.Bridge.Implementations;

/// <summary>
/// RasterRenderer class. Concrete implementor for raster rendering.
/// </summary>
public class RasterRenderer : IRenderer
{
    /// <summary>
    /// Renders a circle using raster graphics.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing a circle of radius {radius} with raster rendering.");
    }
}