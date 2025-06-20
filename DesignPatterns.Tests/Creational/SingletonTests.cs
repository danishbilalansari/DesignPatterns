using DesignPatterns.Creational.Singleton;

namespace DesignPatterns.Tests.Creational;

public class SingletonTests : BaseTest
{
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