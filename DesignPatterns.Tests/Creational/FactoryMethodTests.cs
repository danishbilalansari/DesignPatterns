using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.Implementation;

namespace DesignPatterns.Tests.Creational;

/// <summary>
/// FactoryMethodTests class. Contains tests for the Factory Method design pattern implementation.
/// </summary>
public class FactoryMethodTests : BaseTest
{
    private readonly VehicleFactory _factory = new();

    /// <summary>
    /// Verifies that VehicleFactory creates the correct vehicle types.
    /// </summary>

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

    /// <summary>
    /// Verifies that VehicleFactory returns a Bike instance when type is "bike".
    /// </summary>
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

    /// <summary>
    /// Verifies that VehicleFactory throws an ArgumentException for an unsupported vehicle type.
    /// </summary>
    [Fact]
    public void CreateVehicle_Should_Throw_ArgumentException_For_Invalid_Type()
    {
        // Arrange
        var type = "truck";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _factory.CreateVehicle(type));
    }
} 