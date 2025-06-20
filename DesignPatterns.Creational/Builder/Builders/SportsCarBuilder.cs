namespace DesignPatterns.Creational.Builder.Builders;

/// <summary>
/// SportsCarBuilder class. Implements building steps for a sports car.
/// </summary>
public class SportsCarBuilder : CarBuilder
{
    /// <summary>
    /// Builds the engine for the sports car.
    /// </summary>
    /// <returns>The CarBuilder instance.</returns>
    public override CarBuilder BuildEngine()
    {
        car.Engine = "V8";
        return this;
    }

    /// <summary>
    /// Builds the wheels for the sports car.
    /// </summary>
    /// <returns>The CarBuilder instance.</returns>
    public override CarBuilder BuildWheels()
    {
        car.Wheels = "Sporty Wheels";
        return this;
    }

    /// <summary>
    /// Builds the doors for the sports car.
    /// </summary>
    /// <returns>The CarBuilder instance.</returns>
    public override CarBuilder BuildDoors()
    {
        car.Doors = "2 Doors";
        return this;
    }

    /// <summary>
    /// Builds the color for the sports car.
    /// </summary>
    /// <returns>The CarBuilder instance.</returns>
    public override CarBuilder BuildColor()
    {
        car.Color = "Red";
        return this;
    }
}