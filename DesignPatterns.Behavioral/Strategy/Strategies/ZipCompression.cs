namespace DesignPatterns.Behavioral.Strategy.Strategies;

public class ZipCompression : ICompressionStrategy
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"Compressing '{fileName}' using ZIP.");
    }
}
