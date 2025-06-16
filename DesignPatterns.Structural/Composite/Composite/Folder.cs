using DesignPatterns.Structural.Composite.Interfaces;

namespace DesignPatterns.Structural.Composite.Composite;

public class Folder : IComponent
{
    private readonly string _name;
    private readonly List<IComponent> _children = new();

    public Folder(string name)
    {
        _name = name;
    }

    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
        foreach (var child in _children)
        {
            child.Display(depth + 2);
        }
    }
}