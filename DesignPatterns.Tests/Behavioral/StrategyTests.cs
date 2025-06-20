using DesignPatterns.Behavioral.Strategy.Context;
using DesignPatterns.Behavioral.Strategy.Strategies;

namespace DesignPatterns.Tests.Behavioral;

public class StrategyTests : BaseTest
{
    private readonly CompressionContext _context = new();
    
    [Fact]
    public void CompressFile_Should_Use_Zip_Strategy()
    {
        // Arrange
        _context.SetStrategy(new ZipCompression());
        var fileName = "test.zip";
        var expected = $"Compressing '{fileName}' using ZIP.";
        
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act
            _context.CompressFile(fileName);

            // Assert
            sw.Flush();
            Assert.Contains(expected, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    [Fact]
    public void CompressFile_Should_Use_Rar_Strategy()
    {
        // Arrange
        _context.SetStrategy(new RarCompression());
        var fileName = "test.rar";
        var expected = $"Compressing '{fileName}' using RAR.";
        
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act
            _context.CompressFile(fileName);

            // Assert
            sw.Flush();
            Assert.Contains(expected, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 