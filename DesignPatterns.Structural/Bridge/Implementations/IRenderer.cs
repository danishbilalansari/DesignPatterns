namespace DesignPatterns.Structural.Bridge.Implementations;

/// <summary>
/// IRenderer interface. Bridge implementor for rendering shapes.
/// </summary>
public interface IRenderer
{
    /// <summary>
    /// Renders a circle with the given radius.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    void RenderCircle(float radius);
}