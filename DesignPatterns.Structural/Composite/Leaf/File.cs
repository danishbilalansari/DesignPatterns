using DesignPatterns.Structural.Composite.Interfaces;

namespace DesignPatterns.Structural.Composite.Leaf;

public class File : IComponent
{
    private readonly string _name;

    public File(string name)
    {
        _name = name;
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
    }
}