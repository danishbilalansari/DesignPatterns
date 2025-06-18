using DesignPatterns.Behavioral.TemplateMethod.Abstract;

namespace DesignPatterns.Behavioral.TemplateMethod.Concrete;

public class Chess : Game
{
    protected override void Initialize() => Console.WriteLine("Chess Game Initialized!");
    protected override void StartPlay() => Console.WriteLine("Chess Game Started!");
    protected override void EndPlay() => Console.WriteLine("Chess Game Finished!");
}
