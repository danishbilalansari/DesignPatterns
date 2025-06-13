namespace DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

public class MacCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a Mac-style checkbox.");
    }
}
