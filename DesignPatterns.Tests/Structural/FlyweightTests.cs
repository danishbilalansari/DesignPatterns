using DesignPatterns.Structural.Flyweight.Factory;

namespace DesignPatterns.Tests.Structural;

public class FlyweightTests : BaseTest
{
    [Fact]
    public void GetCharacter_Should_Return_Same_Instance_For_Same_Symbol()
    {
        // Arrange
        var factory = new CharacterFactory();

        // Act
        var charA1 = factory.GetCharacter('A');
        var charA2 = factory.GetCharacter('A');
        var charB = factory.GetCharacter('B');

        // Assert
        Assert.Same(charA1, charA2);
        Assert.NotSame(charA1, charB);
    }
} 