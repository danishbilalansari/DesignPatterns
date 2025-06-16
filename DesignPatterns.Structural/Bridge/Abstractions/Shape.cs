using DesignPatterns.Structural.Bridge.Implementations;

namespace DesignPatterns.Structural.Bridge.Abstractions;

public abstract class Shape
{
    protected IRenderer renderer;

    protected Shape(IRenderer renderer)
    {
        this.renderer = renderer;
    }

    public abstract void Draw();
}