using DesignPatterns.Creational.AbstractFactory.Products.Buttons;
using DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}