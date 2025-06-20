namespace DesignPatterns.Structural.Composite.Interfaces;

/// <summary>
/// IComponent interface. Represents a component in the file system tree.
/// </summary>
public interface IComponent
{
    /// <summary>
    /// Displays the component.
    /// </summary>
    /// <param name="depth">The depth in the tree.</param>
    void Display(int depth);
}