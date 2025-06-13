using DesignPatterns.Creational.AbstractFactory.Products.Buttons;
using DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}