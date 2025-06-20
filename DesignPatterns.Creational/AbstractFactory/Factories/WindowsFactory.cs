using DesignPatterns.Creational.AbstractFactory.Products.Buttons;
using DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

/// <summary>
/// WindowsFactory class. Concrete factory for Windows GUI components.
/// </summary>
public class WindowsFactory : IGUIFactory
{
    /// <summary>
    /// Creates a Windows-style button.
    /// </summary>
    /// <returns>An IButton instance.</returns>
    public IButton CreateButton() => new WindowsButton();
    /// <summary>
    /// Creates a Windows-style checkbox.
    /// </summary>
    /// <returns>An ICheckbox instance.</returns>
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}