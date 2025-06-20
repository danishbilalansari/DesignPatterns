using DesignPatterns.Structural.Flyweight.Factory;

namespace DesignPatterns.Tests.Structural;

/// <summary>
/// FlyweightTests class. Contains tests for the Flyweight design pattern implementation.
/// </summary>
public class FlyweightTests : BaseTest
{
    /// <summary>
    /// Verifies that CharacterFactory reuses flyweight Character objects.
    /// </summary>
    [Fact]
    public void GetCharacter_Should_Reuse_Flyweight_Instances()
    {
        // Arrange: Create the factory
        var factory = new CharacterFactory();

        // Act: Get characters for the same symbol
        var charA1 = factory.GetCharacter('A');
        var charA2 = factory.GetCharacter('A');
        var charB = factory.GetCharacter('B');

        // Assert: The same symbol should return the same instance
        Assert.Same(charA1, charA2);
        Assert.NotSame(charA1, charB);
    }
} 