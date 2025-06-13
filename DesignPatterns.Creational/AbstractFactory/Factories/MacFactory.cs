using DesignPatterns.Creational.AbstractFactory.Products.Buttons;
using DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}