using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod.Implementation;

/// <summary>
/// Car class. Represents a car vehicle.
/// </summary>
public class Car : IVehicle
{
    /// <summary>
    /// Drives the car.
    /// </summary>
    public void Drive() => Console.WriteLine("Driving a car");
}