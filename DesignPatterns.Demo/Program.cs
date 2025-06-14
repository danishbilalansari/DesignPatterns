using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.FactoryMethod.Interfaces;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Models;
using DesignPatterns.Creational.Prototype.Clients;
using DesignPatterns.Creational.Prototype.Models;

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


// Prototype Pattern
Console.WriteLine("\nPrototype Pattern");

// Create a new ConcreteProduct prototype
Product product1 = new ConcreteProduct("Laptop", "Electronics");

// Set additional properties if needed
Console.WriteLine("Original Product:");
product1.ShowDetails();
((ConcreteProduct)product1).ShowCategory();

// Create a client that will clone the product
Client client = new Client(product1);

// Clone the product
Product clonedProduct = client.GetClone();
Console.WriteLine("\nCloned Product:");
clonedProduct.ShowDetails();
((ConcreteProduct)clonedProduct).ShowCategory();

Console.WriteLine("\nDemo complete. Press any key to exit...");
Console.ReadKey();