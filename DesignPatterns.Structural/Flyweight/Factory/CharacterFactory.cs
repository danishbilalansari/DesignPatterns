using DesignPatterns.Structural.Flyweight.Flyweights;

namespace DesignPatterns.Structural.Flyweight.Factory;

public class CharacterFactory
{
    private readonly Dictionary<char, Character> _characters = new();

    public Character GetCharacter(char symbol)
    {
        if (!_characters.ContainsKey(symbol))
        {
            _characters[symbol] = new Character(symbol);
        }

        return _characters[symbol];
    }
}