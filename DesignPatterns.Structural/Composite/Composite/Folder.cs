using DesignPatterns.Structural.Composite.Interfaces;

namespace DesignPatterns.Structural.Composite.Composite;

/// <summary>
/// Folder class. Composite node in the file system tree.
/// </summary>
public class Folder : IComponent
{
    private readonly string _name;
    private readonly List<IComponent> _children = new();

    /// <summary>
    /// Initializes a new instance of Folder.
    /// </summary>
    /// <param name="name">The name of the folder.</param>
    public Folder(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Adds a child component to the folder.
    /// </summary>
    /// <param name="component">The component to add.</param>
    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    /// <summary>
    /// Displays the folder and its children.
    /// </summary>
    /// <param name="depth">The depth in the tree.</param>
    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
        foreach (var child in _children)
        {
            child.Display(depth + 2);
        }
    }
}