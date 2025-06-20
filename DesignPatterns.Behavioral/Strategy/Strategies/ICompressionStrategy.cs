namespace DesignPatterns.Behavioral.Strategy.Strategies;

/// <summary>
/// ICompressionStrategy interface. Represents a compression strategy.
/// </summary>
public interface ICompressionStrategy
{
    /// <summary>
    /// Compresses the specified file.
    /// </summary>
    /// <param name="fileName">The name of the file to compress.</param>
    void Compress(string fileName);
}