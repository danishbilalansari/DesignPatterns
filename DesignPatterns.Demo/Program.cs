using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.FactoryMethod.Interfaces;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Models;

// Singleton Pattern
Console.WriteLine("Singleton Pattern");
var singleton1 = Singleton.Instance;
var singleton2 = Singleton.Instance;
singleton1.DoSomething();
Console.WriteLine($"Is singleton1 same as singleton2? {ReferenceEquals(singleton1, singleton2)}");


// Factory Method Pattern
Console.WriteLine("\nFactory Method Pattern");

var vehicleFactory = new VehicleFactory();

Console.WriteLine("Enter vehicle type (car/bike):");
string? vehicleType = Console.ReadLine();

try
{
    IVehicle vehicle = vehicleFactory.CreateVehicle(vehicleType ?? "");
    vehicle.Drive();
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}


// Abstract Factory Method
Console.WriteLine("\nAbstract Factory Pattern");

Console.WriteLine("Enter UI platform (windows/mac):");
string? platform = Console.ReadLine()?.ToLower();

IGUIFactory guiFactory = platform switch
{
    "windows" => new WindowsFactory(),
    "mac" => new MacFactory(),
    _ => throw new ArgumentException("Unsupported platform")
};

var button = guiFactory.CreateButton();
var checkbox = guiFactory.CreateCheckbox();

button.Paint();
checkbox.Paint();


// Builder Pattern
Console.WriteLine("\nBuilder Pattern");
CarBuilder builder = new SportsCarBuilder();
Car car = builder.CreateNewCar()
                 .BuildEngine()
                 .BuildWheels()
                 .BuildDoors()
                 .BuildColor()
                 .Build();

car.ShowDetails();

Console.WriteLine("\nDemo complete. Press any key to exit...");
Console.ReadKey();