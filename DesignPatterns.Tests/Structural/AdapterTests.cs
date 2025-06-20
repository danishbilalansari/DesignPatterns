using DesignPatterns.Structural.Adadpter.Adapters;

namespace DesignPatterns.Tests.Structural;

/// <summary>
/// AdapterTests class. Contains tests for the Adapter design pattern implementation.
/// </summary>
public class AdapterTests : BaseTest
{
    /// <summary>
    /// Verifies that LoggerAdapter uses OldLogger to write the log message.
    /// </summary>
    [Fact]
    public void Log_Should_Use_OldLogger_To_Write_Message()
    {
        // Arrange: Create the adapter and expected output
        var adapter = new LoggerAdapter();
        var message = "Test log message";
        var expectedOutput = "Old Logger: " + message;
        
        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: Log the message
            adapter.Log(message);

            // Assert: The output should match the expected log message
            sw.Flush();
            Assert.Contains(expectedOutput, sw.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 