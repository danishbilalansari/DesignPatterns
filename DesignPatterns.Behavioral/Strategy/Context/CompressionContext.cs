using DesignPatterns.Behavioral.Strategy.Strategies;

namespace DesignPatterns.Behavioral.Strategy.Context;

/// <summary>
/// CompressionContext class. Maintains a reference to a compression strategy.
/// </summary>
public class CompressionContext
{
    private ICompressionStrategy _strategy;

    public void SetStrategy(ICompressionStrategy strategy)
    {
        _strategy = strategy;
    }

    public void CompressFile(string fileName)
    {
        _strategy?.Compress(fileName);
    }
}
