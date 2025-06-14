namespace DesignPatterns.Creational.Prototype.Models;

public class ConcreteProduct : Product
{
    public string Category { get; set; }

    public ConcreteProduct(string name, string category)
    {
        Name = name;
        Category = category;
    }

    // Implement the Clone method
    public override Product Clone()
    {
        // Perform a shallow copy (can be replaced with deep copy if needed)
        return (Product)this.MemberwiseClone();
    }

    public void ShowCategory()
    {
        Console.WriteLine($"Category: {Category}");
    }
}