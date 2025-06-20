using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Builders;

/// <summary>
/// CarBuilder abstract class. Defines the steps to build a car.
/// </summary>
public abstract class CarBuilder
{
    protected Car car;

    /// <summary>
    /// Creates a new car instance.
    /// </summary>
    /// <returns>The CarBuilder instance.</returns>
    public CarBuilder CreateNewCar()
    {
        car = new Car();
        return this;
    }

    /// <summary>
    /// Builds the engine for the car.
    /// </summary>
    /// <returns>The CarBuilder instance.</returns>
    public abstract CarBuilder BuildEngine();
    /// <summary>
    /// Builds the wheels for the car.
    /// </summary>
    /// <returns>The CarBuilder instance.</returns>
    public abstract CarBuilder BuildWheels();
    /// <summary>
    /// Builds the doors for the car.
    /// </summary>
    /// <returns>The CarBuilder instance.</returns>
    public abstract CarBuilder BuildDoors();
    /// <summary>
    /// Builds the color for the car.
    /// </summary>
    /// <returns>The CarBuilder instance.</returns>
    public abstract CarBuilder BuildColor();

    /// <summary>
    /// Returns the built car.
    /// </summary>
    /// <returns>The built Car object.</returns>
    public Car Build() => car;
}