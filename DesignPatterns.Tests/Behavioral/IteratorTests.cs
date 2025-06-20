using DesignPatterns.Behavioral.Iterator.Concrete;

namespace DesignPatterns.Tests.Behavioral;

/// <summary>
/// IteratorTests class. Contains tests for the Iterator design pattern implementation.
/// </summary>
public class IteratorTests : BaseTest
{
    /// <summary>
    /// Verifies that the NameIterator iterates through all items in the collection.
    /// </summary>
    [Fact]
    public void Iterator_Should_Iterate_Through_All_Items()
    {
        // Arrange: Create the repository and iterator
        var repository = new NameRepository();
        var iterator = repository.CreateIterator();
        var iteratedNames = new List<string>();
        
        // Act: Iterate through all items
        while (iterator.HasNext())
        {
            iteratedNames.Add(iterator.Next());
        }

        // Assert: The iterated names should match the expected sequence
        Assert.Equal(new[] { "Alice", "Bob", "Charlie" }, iteratedNames);
    }
} 