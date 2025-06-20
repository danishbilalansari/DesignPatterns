using DesignPatterns.Creational.AbstractFactory.Products.Buttons;
using DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

/// <summary>
/// IGUIFactory interface. Abstract factory for GUI components.
/// </summary>
public interface IGUIFactory
{
    /// <summary>
    /// Creates a button.
    /// </summary>
    /// <returns>An IButton instance.</returns>
    IButton CreateButton();
    /// <summary>
    /// Creates a checkbox.
    /// </summary>
    /// <returns>An ICheckbox instance.</returns>
    ICheckbox CreateCheckbox();
}