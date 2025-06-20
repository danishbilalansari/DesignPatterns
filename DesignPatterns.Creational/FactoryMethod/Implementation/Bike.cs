using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod.Implementation;

/// <summary>
/// Bike class. Represents a bike vehicle.
/// </summary>
public class Bike : IVehicle
{
    /// <summary>
    /// Rides the bike.
    /// </summary>
    public void Drive() => Console.WriteLine("Riding a bike");
}