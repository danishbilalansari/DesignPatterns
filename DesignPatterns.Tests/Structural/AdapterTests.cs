using DesignPatterns.Structural.Adadpter.Adapters;

namespace DesignPatterns.Tests.Structural;

public class AdapterTests : BaseTest
{
    [Fact]
    public void Log_Should_Use_OldLogger_To_Write_Message()
    {
        // Arrange
        var adapter = new LoggerAdapter();
        var message = "Test log message";
        var expectedOutput = "Old Logger: " + message;
        
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act
            adapter.Log(message);

            // Assert
            sw.Flush();
            Assert.Contains(expectedOutput, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 