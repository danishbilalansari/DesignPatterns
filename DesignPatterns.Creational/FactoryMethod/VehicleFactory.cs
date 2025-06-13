using DesignPatterns.Creational.FactoryMethod.Implementation;
using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod;

public class VehicleFactory
{
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