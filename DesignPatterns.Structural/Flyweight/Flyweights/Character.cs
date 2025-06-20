namespace DesignPatterns.Structural.Flyweight.Flyweights;

/// <summary>
/// Character class. Flyweight object representing a character symbol.
/// </summary>
public class Character
{
    public char Symbol { get; }

    /// <summary>
    /// Initializes a new instance of Character.
    /// </summary>
    /// <param name="symbol">The character symbol.</param>
    public Character(char symbol)
    {
        Symbol = symbol;
    }

    /// <summary>
    /// Displays the character symbol.
    /// </summary>
    public void Display() => Console.Write(Symbol + " ");
}