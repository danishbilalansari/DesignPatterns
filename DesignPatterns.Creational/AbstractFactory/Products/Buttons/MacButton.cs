namespace DesignPatterns.Creational.AbstractFactory.Products.Buttons;

public class MacButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a Mac-style button.");
    }
}