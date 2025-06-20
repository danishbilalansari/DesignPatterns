using DesignPatterns.Behavioral.TemplateMethod.Abstract;

namespace DesignPatterns.Behavioral.TemplateMethod.Concrete;

/// <summary>
/// Football class. Concrete implementation of the Game template.
/// </summary>
public class Football : Game
{
    /// <summary>
    /// Initializes the football game.
    /// </summary>
    protected override void Initialize() => Console.WriteLine("Football Game Initialized!");
    /// <summary>
    /// Starts the football game.
    /// </summary>
    protected override void StartPlay() => Console.WriteLine("Football Game Started!");
    /// <summary>
    /// Ends the football game.
    /// </summary>
    protected override void EndPlay() => Console.WriteLine("Football Game Finished!");
}
