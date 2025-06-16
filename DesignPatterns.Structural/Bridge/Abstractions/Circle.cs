using DesignPatterns.Structural.Bridge.Implementations;

namespace DesignPatterns.Structural.Bridge.Abstractions;

public class Circle : Shape
{
    private readonly float _radius;

    public Circle(IRenderer renderer, float radius) : base(renderer)
    {
        _radius = radius;
    }

    public override void Draw()
    {
        renderer.RenderCircle(_radius);
    }
}
