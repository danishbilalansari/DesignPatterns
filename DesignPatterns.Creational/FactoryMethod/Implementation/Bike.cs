using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod.Implementation;

public class Bike : IVehicle
{
    public void Drive() => Console.WriteLine("Riding a bike");
}