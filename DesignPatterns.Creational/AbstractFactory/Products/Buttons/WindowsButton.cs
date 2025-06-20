namespace DesignPatterns.Creational.AbstractFactory.Products.Buttons;

/// <summary>
/// WindowsButton class. Represents a Windows-style button.
/// </summary>
public class WindowsButton : IButton
{
    /// <summary>
    /// Paints the Windows-style button.
    /// </summary>
    public void Paint()
    {
        Console.WriteLine("Rendering a Windows-style button.");
    }
}