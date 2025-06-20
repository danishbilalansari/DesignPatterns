namespace DesignPatterns.Behavioral.Interpreter.Interfaces;

/// <summary>
/// IExpression interface. Represents an expression in the interpreter pattern.
/// </summary>
public interface IExpression
{
    /// <summary>
    /// Interprets the expression and returns the result.
    /// </summary>
    /// <returns>The result of the interpretation.</returns>
    int Interpret();
}
