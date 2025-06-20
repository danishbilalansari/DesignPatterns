using DesignPatterns.Creational.FactoryMethod.Implementation;
using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod;

/// <summary>
/// VehicleFactory class. Creates vehicle objects based on type.
/// </summary>
public class VehicleFactory
{
    /// <summary>
    /// Creates a vehicle instance based on the provided type.
    /// </summary>
    /// <param name="type">The type of vehicle (e.g., "car", "bike").</param>
    /// <returns>An IVehicle instance.</returns>
    public IVehicle CreateVehicle(string type)
    {
        return type.ToLower() switch
        {
            "car" => new Car(),
            "bike" => new Bike(),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
    }
}