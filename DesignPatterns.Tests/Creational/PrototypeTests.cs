using DesignPatterns.Creational.Prototype.Models;

namespace DesignPatterns.Tests.Creational;

public class PrototypeTests : BaseTest
{
    [Fact]
    public void Clone_Should_Create_New_Instance_With_Same_Values()
    {
        // Arrange
        var original = new ConcreteProduct("Product 1", "Category A");

        // Act
        var clone = original.Clone() as ConcreteProduct;

        // Assert
        Assert.NotNull(clone);
        Assert.NotSame(original, clone);
        Assert.Equal(original.Name, clone.Name);
        Assert.Equal(original.Category, clone.Category);
    }
} 