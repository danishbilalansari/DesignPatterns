namespace DesignPatterns.Creational.Prototype.Models;

public abstract class Product
{
    public string Name { get; set; }

    // Clone method (prototype)
    public abstract Product Clone();

    public void ShowDetails()
    {
        Console.WriteLine($"Product: {Name}");
    }
}