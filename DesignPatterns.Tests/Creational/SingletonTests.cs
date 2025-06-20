using DesignPatterns.Creational.Singleton;

namespace DesignPatterns.Tests.Creational;

/// <summary>
/// SingletonTests class. Contains tests for the Singleton design pattern implementation.
/// </summary>
public class SingletonTests : BaseTest
{
    /// <summary>
    /// Verifies that Singleton returns the same instance every time.
    /// </summary>
    [Fact]
    public void Singleton_Should_Return_Same_Instance()
    {
        // Arrange & Act
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;
        
        // Assert
        Assert.Same(instance1, instance2);
    }
} 