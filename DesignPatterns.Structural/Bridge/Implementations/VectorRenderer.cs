namespace DesignPatterns.Structural.Bridge.Implementations;

/// <summary>
/// VectorRenderer class. Concrete implementor for vector rendering.
/// </summary>
public class VectorRenderer : IRenderer
{
    /// <summary>
    /// Renders a circle using vector graphics.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing a circle of radius {radius} with vector rendering.");
    }
}
