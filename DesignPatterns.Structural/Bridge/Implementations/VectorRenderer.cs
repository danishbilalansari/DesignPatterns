namespace DesignPatterns.Structural.Bridge.Implementations;

public class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing a circle of radius {radius} with vector rendering.");
    }
}
