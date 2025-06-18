namespace DesignPatterns.Behavioral.TemplateMethod.Abstract;

public abstract class Game
{
    public void Play()
    {
        Initialize();
        StartPlay();
        EndPlay();
    }

    protected abstract void Initialize();
    protected abstract void StartPlay();
    protected abstract void EndPlay();
}
