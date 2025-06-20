namespace DesignPatterns.Behavioral.Strategy.Strategies;

/// <summary>
/// ZipCompression class. Concrete strategy for ZIP compression.
/// </summary>
public class ZipCompression : ICompressionStrategy
{
    /// <summary>
    /// Compresses the specified file using ZIP.
    /// </summary>
    /// <param name="fileName">The name of the file to compress.</param>
    public void Compress(string fileName)
    {
        Console.WriteLine($"Compressing '{fileName}' using ZIP.");
    }
}
