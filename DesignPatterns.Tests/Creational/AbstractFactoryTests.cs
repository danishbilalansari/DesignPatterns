using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Products.Buttons;
using DesignPatterns.Creational.AbstractFactory.Products.Checkboxes;

namespace DesignPatterns.Tests.Creational;

/// <summary>
/// AbstractFactoryTests class. Contains tests for the Abstract Factory design pattern implementation.
/// </summary>
public class AbstractFactoryTests : BaseTest
{
    /// <summary>
    /// Verifies that MacFactory creates MacButton and MacCheckbox, and WindowsFactory creates WindowsButton and WindowsCheckbox.
    /// </summary>
    [Fact]
    public void WindowsFactory_Should_Create_Windows_Components()
    {
        // Arrange
        var factory = new WindowsFactory();

        // Act
        var button = factory.CreateButton();
        var checkbox = factory.CreateCheckbox();

        // Assert
        Assert.NotNull(button);
        Assert.IsType<WindowsButton>(button);
        Assert.NotNull(checkbox);
        Assert.IsType<WindowsCheckbox>(checkbox);
    }

    /// <summary>
    /// Verifies that MacFactory creates MacButton and MacCheckbox.
    /// </summary>
    [Fact]
    public void MacFactory_Should_Create_Mac_Components()
    {
        // Arrange
        var factory = new MacFactory();

        // Act
        var button = factory.CreateButton();
        var checkbox = factory.CreateCheckbox();

        // Assert
        Assert.NotNull(button);
        Assert.IsType<MacButton>(button);
        Assert.NotNull(checkbox);
        Assert.IsType<MacCheckbox>(checkbox);
    }
} 