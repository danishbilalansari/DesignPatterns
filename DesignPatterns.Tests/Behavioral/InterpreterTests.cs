using DesignPatterns.Behavioral.Interpreter.Expressions;
using DesignPatterns.Behavioral.Interpreter.Interfaces;

namespace DesignPatterns.Tests.Behavioral;

public class InterpreterTests : BaseTest
{
    [Fact]
    public void Interpret_Should_Return_Correct_Result_For_Expression()
    {
        // Represents the expression: (10 + 5) - 3
        
        // Arrange
        IExpression expression = new SubtractExpression(
            new AddExpression(new NumberExpression(10), new NumberExpression(5)),
            new NumberExpression(3)
        );
        var expected = 12;

        // Act
        var result = expression.Interpret();

        // Assert
        Assert.Equal(expected, result);
    }
} 