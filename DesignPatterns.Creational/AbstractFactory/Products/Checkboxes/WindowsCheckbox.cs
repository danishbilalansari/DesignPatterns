namespace DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

public class WindowsCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a Windows-style checkbox.");
    }
}