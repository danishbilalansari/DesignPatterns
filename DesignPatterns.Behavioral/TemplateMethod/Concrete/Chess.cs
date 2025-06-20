using DesignPatterns.Behavioral.TemplateMethod.Abstract;

namespace DesignPatterns.Behavioral.TemplateMethod.Concrete;

/// <summary>
/// Chess class. Concrete implementation of the Game template.
/// </summary>
public class Chess : Game
{
    /// <summary>
    /// Initializes the chess game.
    /// </summary>
    protected override void Initialize() => Console.WriteLine("Chess Game Initialized!");
    /// <summary>
    /// Starts the chess game.
    /// </summary>
    protected override void StartPlay() => Console.WriteLine("Chess Game Started!");
    /// <summary>
    /// Ends the chess game.
    /// </summary>
    protected override void EndPlay() => Console.WriteLine("Chess Game Finished!");
}
