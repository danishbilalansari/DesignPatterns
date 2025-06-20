using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.Implementation;

namespace DesignPatterns.Tests.Creational;

public class FactoryMethodTests : BaseTest
{
    private readonly VehicleFactory _factory = new();

    [Fact]
    public void CreateVehicle_Should_Return_Car_When_Type_Is_Car()
    {
        // Arrange
        var type = "car";

        // Act
        var vehicle = _factory.CreateVehicle(type);

        // Assert
        Assert.NotNull(vehicle);
        Assert.IsType<Car>(vehicle);
    }

    [Fact]
    public void CreateVehicle_Should_Return_Bike_When_Type_Is_Bike()
    {
        // Arrange
        var type = "bike";

        // Act
        var vehicle = _factory.CreateVehicle(type);

        // Assert
        Assert.NotNull(vehicle);
        Assert.IsType<Bike>(vehicle);
    }

    [Fact]
    public void CreateVehicle_Should_Throw_ArgumentException_For_Invalid_Type()
    {
        // Arrange
        var type = "truck";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _factory.CreateVehicle(type));
    }
} 