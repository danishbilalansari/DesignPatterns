using DesignPatterns.Structural.Composite.Interfaces;

namespace DesignPatterns.Structural.Composite.Leaf;

/// <summary>
/// File class. Leaf node in the file system tree.
/// </summary>
public class File : IComponent
{
    private readonly string _name;

    /// <summary>
    /// Initializes a new instance of File.
    /// </summary>
    /// <param name="name">The name of the file.</param>
    public File(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Displays the file.
    /// </summary>
    /// <param name="depth">The depth in the tree.</param>
    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
    }
}