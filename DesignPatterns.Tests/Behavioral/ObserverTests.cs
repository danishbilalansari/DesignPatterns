using DesignPatterns.Behavioral.Observer.Observers;
using DesignPatterns.Behavioral.Observer.Subjects;

namespace DesignPatterns.Tests.Behavioral;

/// <summary>
/// ObserverTests class. Contains tests for the Observer design pattern implementation.
/// </summary>
public class ObserverTests : BaseTest
{
    /// <summary>
    /// Verifies that all registered observers are notified when the subject's state changes.
    /// </summary>
    [Fact]
    public void SetTemperature_Should_Notify_All_Registered_Observers()
    {
        // Arrange: Set up the subject and observers
        var weatherStation = new WeatherStation();
        var phoneDisplay = new PhoneDisplay();
        var windowDisplay = new WindowDisplay();
        
        weatherStation.Register(phoneDisplay);
        weatherStation.Register(windowDisplay);
        
        var expectedLines = new[]
        {
            "Phone Display: Current temperature is 25.5°C",
            "Window Display: Current temperature is 25.5°C"
        };

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);
        
        try
        {
            // Act: Change the temperature
            weatherStation.SetTemperature(25.5f);
            
            // Assert: All observers should be notified
            sw.Flush();
            var output = sw.ToString();
            foreach (var line in expectedLines)
            {
                Assert.Contains(line, output);
            }
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 