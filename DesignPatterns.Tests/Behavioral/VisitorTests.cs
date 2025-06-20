using DesignPatterns.Behavioral.Visitor.Elements;
using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Tests.Behavioral;

/// <summary>
/// VisitorTests class. Contains tests for the Visitor design pattern implementation.
/// </summary>
public class VisitorTests : BaseTest
{
    /// <summary>
    /// Verifies that the PriceCalculatorVisitor calculates the total price of elements.
    /// </summary>
    [Fact]
    public void PriceCalculatorVisitor_Should_Calculate_Total_Price_Of_Elements()
    {
        // Arrange: Create a list of elements (Book and Fruit)
        var elements = new List<IElement>
        {
            new Book("Design Patterns", 25.00),
            new Fruit("Apple", 1.5, 2.00) // 1.5kg at $2.00/kg = $3.00
        };
        var visitor = new PriceCalculatorVisitor();
        var expectedTotal = 28.00;

        // Act: Accept the visitor for each element
        foreach (var element in elements)
        {
            element.Accept(visitor);
        }
        var total = visitor.Total;

        // Assert: The total should match the expected value
        Assert.Equal(expectedTotal, total);
    }
} 