using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod.Implementation;

public class Car : IVehicle
{
    public void Drive() => Console.WriteLine("Driving a car");
}