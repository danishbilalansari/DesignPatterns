using DesignPatterns.Behavioral.Strategy.Context;
using DesignPatterns.Behavioral.Strategy.Strategies;

namespace DesignPatterns.Tests.Behavioral;

/// <summary>
/// StrategyTests class. Contains tests for the Strategy design pattern implementation.
/// </summary>
public class StrategyTests : BaseTest
{
    private readonly CompressionContext _context = new();
    
    /// <summary>
    /// Verifies that the context uses the ZipCompression strategy to compress a file.
    /// </summary>
    [Fact]
    public void CompressFile_Should_Use_Zip_Strategy()
    {
        // Arrange: Set the strategy to ZipCompression
        _context.SetStrategy(new ZipCompression());
        var fileName = "test.zip";
        var expected = $"Compressing '{fileName}' using ZIP.";
        
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: Compress the file
            _context.CompressFile(fileName);

            // Assert: The output should indicate ZIP compression
            sw.Flush();
            Assert.Contains(expected, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    /// <summary>
    /// Verifies that the context uses the RarCompression strategy to compress a file.
    /// </summary>
    [Fact]
    public void CompressFile_Should_Use_Rar_Strategy()
    {
        // Arrange: Set the strategy to RarCompression
        _context.SetStrategy(new RarCompression());
        var fileName = "test.rar";
        var expected = $"Compressing '{fileName}' using RAR.";
        
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: Compress the file
            _context.CompressFile(fileName);

            // Assert: The output should indicate RAR compression
            sw.Flush();
            Assert.Contains(expected, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 