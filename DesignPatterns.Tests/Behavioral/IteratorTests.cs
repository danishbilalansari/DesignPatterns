using DesignPatterns.Behavioral.Iterator.Concrete;

namespace DesignPatterns.Tests.Behavioral;

public class IteratorTests : BaseTest
{
    [Fact]
    public void Iterator_Should_Iterate_Through_All_Items()
    {
        // Arrange
        var repository = new NameRepository();
        var iterator = repository.CreateIterator();
        var iteratedNames = new List<string>();
        
        // Act
        while (iterator.HasNext())
        {
            iteratedNames.Add(iterator.Next());
        }

        // Assert
        Assert.Equal(new[] { "Alice", "Bob", "Charlie" }, iteratedNames);
    }
} 