using DesignPatterns.Structural.Bridge.Implementations;

namespace DesignPatterns.Structural.Bridge.Abstractions;

/// <summary>
/// Circle class. Concrete shape abstraction.
/// </summary>
public class Circle : Shape
{
    private readonly float _radius;

    public Circle(IRenderer renderer, float radius) : base(renderer)
    {
        _radius = radius;
    }

    /// <summary>
    /// Draws the circle using the renderer.
    /// </summary>
    public override void Draw()
    {
        renderer.RenderCircle(_radius);
    }
}
