namespace DesignPatterns.Creational.AbstractFactory.Products.Buttons;

public class WindowsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a Windows-style button.");
    }
}