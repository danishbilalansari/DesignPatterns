using DesignPatterns.Creational.AbstractFactory.Products.Buttons;
using DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

/// <summary>
/// MacFactory class. Concrete factory for Mac GUI components.
/// </summary>
public class MacFactory : IGUIFactory
{
    /// <summary>
    /// Creates a Mac-style button.
    /// </summary>
    /// <returns>An IButton instance.</returns>
    public IButton CreateButton() => new MacButton();
    /// <summary>
    /// Creates a Mac-style checkbox.
    /// </summary>
    /// <returns>An ICheckbox instance.</returns>
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}