namespace DesignPatterns.Creational.AbstractFactory.Products.Buttons;

/// <summary>
/// MacButton class. Represents a Mac-style button.
/// </summary>
public class MacButton : IButton
{
    /// <summary>
    /// Paints the Mac-style button.
    /// </summary>
    public void Paint()
    {
        Console.WriteLine("Rendering a Mac-style button.");
    }
}