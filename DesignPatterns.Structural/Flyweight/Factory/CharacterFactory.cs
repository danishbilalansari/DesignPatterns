using DesignPatterns.Structural.Flyweight.Flyweights;

namespace DesignPatterns.Structural.Flyweight.Factory;

/// <summary>
/// CharacterFactory class. Creates and manages flyweight Character objects.
/// </summary>
public class CharacterFactory
{
    private readonly Dictionary<char, Character> _characters = new();

    /// <summary>
    /// Gets a Character flyweight for the given symbol.
    /// </summary>
    /// <param name="symbol">The character symbol.</param>
    /// <returns>A Character instance.</returns>
    public Character GetCharacter(char symbol)
    {
        if (!_characters.ContainsKey(symbol))
        {
            _characters[symbol] = new Character(symbol);
        }

        return _characters[symbol];
    }
}