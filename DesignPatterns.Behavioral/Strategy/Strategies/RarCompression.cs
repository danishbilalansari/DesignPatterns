namespace DesignPatterns.Behavioral.Strategy.Strategies;

/// <summary>
/// RarCompression class. Concrete strategy for RAR compression.
/// </summary>
public class RarCompression : ICompressionStrategy
{
    /// <summary>
    /// Compresses the specified file using RAR.
    /// </summary>
    /// <param name="fileName">The name of the file to compress.</param>
    public void Compress(string fileName)
    {
        Console.WriteLine($"Compressing '{fileName}' using RAR.");
    }
}
