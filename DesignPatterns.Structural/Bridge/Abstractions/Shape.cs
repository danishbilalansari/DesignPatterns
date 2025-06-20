using DesignPatterns.Structural.Bridge.Implementations;

namespace DesignPatterns.Structural.Bridge.Abstractions;

/// <summary>
/// Shape abstract class. Bridge abstraction for shapes.
/// </summary>
public abstract class Shape
{
    protected IRenderer renderer;

    protected Shape(IRenderer renderer)
    {
        this.renderer = renderer;
    }

    /// <summary>
    /// Draws the shape using the renderer.
    /// </summary>
    public abstract void Draw();
}