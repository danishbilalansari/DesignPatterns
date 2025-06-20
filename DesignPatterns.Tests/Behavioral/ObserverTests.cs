using DesignPatterns.Behavioral.Observer.Observers;
using DesignPatterns.Behavioral.Observer.Subjects;

namespace DesignPatterns.Tests.Behavioral;

public class ObserverTests : BaseTest
{
    [Fact]
    public void SetTemperature_Should_Notify_All_Registered_Observers()
    {
        // Arrange
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
            // Act
            weatherStation.SetTemperature(25.5f);
            
            // Assert
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