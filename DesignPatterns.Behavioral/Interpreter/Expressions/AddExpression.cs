using DesignPatterns.Behavioral.Interpreter.Interfaces;

namespace DesignPatterns.Behavioral.Interpreter.Expressions;

/// <summary>
/// AddExpression class. Represents an addition operation in the interpreter pattern.
/// </summary>
public class AddExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    /// <summary>
    /// Initializes a new instance of AddExpression.
    /// </summary>
    /// <param name="left">The left operand expression.</param>
    /// <param name="right">The right operand expression.</param>
    public AddExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    /// <summary>
    /// Interprets the addition expression.
    /// </summary>
    /// <returns>The result of the addition.</returns>
    public int Interpret() => _left.Interpret() + _right.Interpret();
}
