using DesignPatterns.Behavioral.TemplateMethod.Abstract;

namespace DesignPatterns.Behavioral.TemplateMethod.Concrete;

public class Football : Game
{
    protected override void Initialize() => Console.WriteLine("Football Game Initialized!");
    protected override void StartPlay() => Console.WriteLine("Football Game Started!");
    protected override void EndPlay() => Console.WriteLine("Football Game Finished!");
}
