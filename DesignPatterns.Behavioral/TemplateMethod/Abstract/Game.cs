namespace DesignPatterns.Behavioral.TemplateMethod.Abstract;

/// <summary>
/// Game abstract class. Defines the template method for playing a game.
/// </summary>
public abstract class Game
{
    /// <summary>
    /// Template method for playing the game.
    /// </summary>
    public void Play()
    {
        Initialize();
        StartPlay();
        EndPlay();
    }

    /// <summary>
    /// Initializes the game.
    /// </summary>
    protected abstract void Initialize();
    /// <summary>
    /// Starts the game play.
    /// </summary>
    protected abstract void StartPlay();
    /// <summary>
    /// Ends the game play.
    /// </summary>
    protected abstract void EndPlay();
}
