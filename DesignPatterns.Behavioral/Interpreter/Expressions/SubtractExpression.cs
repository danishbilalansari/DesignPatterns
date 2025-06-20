using DesignPatterns.Behavioral.Interpreter.Interfaces;

namespace DesignPatterns.Behavioral.Interpreter.Expressions;

/// <summary>
/// SubtractExpression class. Represents a subtraction operation in the interpreter pattern.
/// </summary>
public class SubtractExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    /// <summary>
    /// Initializes a new instance of SubtractExpression.
    /// </summary>
    /// <param name="left">The left operand expression.</param>
    /// <param name="right">The right operand expression.</param>
    public SubtractExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    /// <summary>
    /// Interprets the subtraction expression.
    /// </summary>
    /// <returns>The result of the subtraction.</returns>
    public int Interpret() => _left.Interpret() - _right.Interpret();
}
