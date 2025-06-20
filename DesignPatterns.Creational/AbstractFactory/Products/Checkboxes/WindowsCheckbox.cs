namespace DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

/// <summary>
/// WindowsCheckbox class. Represents a Windows-style checkbox.
/// </summary>
public class WindowsCheckbox : ICheckbox
{
    /// <summary>
    /// Paints the Windows-style checkbox.
    /// </summary>
    public void Paint()
    {
        Console.WriteLine("Rendering a Windows-style checkbox.");
    }
}