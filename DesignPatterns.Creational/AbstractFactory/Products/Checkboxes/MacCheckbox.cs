namespace DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

/// <summary>
/// MacCheckbox class. Represents a Mac-style checkbox.
/// </summary>
public class MacCheckbox : ICheckbox
{
    /// <summary>
    /// Paints the Mac-style checkbox.
    /// </summary>
    public void Paint()
    {
        Console.WriteLine("Rendering a Mac-style checkbox.");
    }
}
