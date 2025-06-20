using DesignPatterns.Behavioral.Visitor.Elements;
using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Tests.Behavioral;

public class VisitorTests
{
    [Fact]
    public void PriceCalculatorVisitor_Should_Calculate_Total_Price_Of_Elements()
    {
        // Arrange
        var elements = new List<IElement>
        {
            new Book("Design Patterns", 25.00),
            new Fruit("Apple", 1.5, 2.00) // 1.5kg at $2.00/kg = $3.00
        };
        var visitor = new PriceCalculatorVisitor();
        var expectedTotal = 28.00;

        // Act
        foreach (var element in elements)
        {
            element.Accept(visitor);
        }
        var total = visitor.Total;

        // Assert
        Assert.Equal(expectedTotal, total);
    }
} 