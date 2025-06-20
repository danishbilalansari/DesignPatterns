using DesignPatterns.Behavioral.Interpreter.Interfaces;

namespace DesignPatterns.Behavioral.Interpreter.Expressions;

/// <summary>
/// NumberExpression class. Represents a number in the interpreter pattern.
/// </summary>
public class NumberExpression : IExpression
{
    private readonly int _number;

    /// <summary>
    /// Initializes a new instance of NumberExpression.
    /// </summary>
    /// <param name="number">The number value.</param>
    public NumberExpression(int number) => _number = number;

    /// <summary>
    /// Interprets the number expression.
    /// </summary>
    /// <returns>The number value.</returns>
    public int Interpret() => _number;
}
