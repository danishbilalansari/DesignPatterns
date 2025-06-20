using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Tests.Creational;

public class BuilderTests : BaseTest
{
    [Fact]
    public void SportsCarBuilder_Should_Construct_Sports_Car_Correctly()
    {
        // Arrange
        var builder = new SportsCarBuilder();

        // Act
        var car = builder
            .CreateNewCar()
            .BuildEngine()
            .BuildWheels()
            .BuildDoors()
            .BuildColor()
            .Build();

        // Assert
        Assert.NotNull(car);
        Assert.IsType<Car>(car);
        Assert.Equal("V8", car.Engine);
        Assert.Equal("Sporty Wheels", car.Wheels);
        Assert.Equal("2 Doors", car.Doors);
        Assert.Equal("Red", car.Color);
    }
} 