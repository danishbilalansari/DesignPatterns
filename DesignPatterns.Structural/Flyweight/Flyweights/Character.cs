namespace DesignPatterns.Structural.Flyweight.Flyweights;

public class Character
{
    public char Symbol { get; }

    public Character(char symbol)
    {
        Symbol = symbol;
    }

    public void Display() => Console.Write(Symbol + " ");
}