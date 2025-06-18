namespace DesignPatterns.Behavioral.Strategy.Strategies;

public class RarCompression : ICompressionStrategy
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"Compressing '{fileName}' using RAR.");
    }
}
