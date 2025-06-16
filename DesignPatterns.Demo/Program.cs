using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Models;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.Interfaces;
using DesignPatterns.Creational.Prototype.Clients;
using DesignPatterns.Creational.Prototype.Models;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adadpter.Adapters;
using DesignPatterns.Structural.Adadpter.Interfaces;
using DesignPatterns.Structural.Bridge.Abstractions;
using DesignPatterns.Structural.Bridge.Implementations;
using DesignPatterns.Structural.Composite.Composite;
using DesignPatterns.Structural.Decorator.Components;
using DesignPatterns.Structural.Decorator.ConcreteComponents;
using DesignPatterns.Structural.Decorator.Decorators;
using DesignPatterns.Structural.Facade.Facade;
using DesignPatterns.Structural.Flyweight.Factory;
using DesignPatterns.Structural.Flyweight.Flyweights;
using DesignPatterns.Structural.Proxy.Interfaces;
using DesignPatterns.Structural.Proxy.Proxy;
using LeafFile = DesignPatterns.Structural.Composite.Leaf.File;

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


// Abstract Factory Pattern
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
Product product1 = new ConcreteProduct("Laptop", "Electronics");
Console.WriteLine("Original Product:");
product1.ShowDetails();
((ConcreteProduct)product1).ShowCategory();
Client client = new Client(product1);
Product clonedProduct = client.GetClone();
Console.WriteLine("Cloned Product:");
clonedProduct.ShowDetails();
((ConcreteProduct)clonedProduct).ShowCategory();


// Adapter Pattern
Console.WriteLine("\nAdapter Pattern:");
INewLogger logger = new LoggerAdapter();
logger.Log("Adapter Pattern in action!");


// Decorator Pattern
Console.WriteLine("\nDecorator Pattern:");
INotifier notifier = new EmailNotifier();
notifier = new SMSDecorator(notifier);
notifier.Send("You have a new notification");


// Composite Pattern
Console.WriteLine("\nComposite Pattern:");
var root = new Folder("Root");
root.Add(new LeafFile("File1.txt"));
root.Add(new LeafFile("File2.txt"));
var sub = new Folder("SubFolder");
sub.Add(new LeafFile("File3.txt"));
root.Add(sub);
root.Display(1);


// Facade Pattern
Console.WriteLine("\nFacade Pattern:");
var mediaFacade = new MediaFacade();
mediaFacade.PlayMedia();


// Flyweight Pattern
Console.WriteLine("\nFlyweight Pattern:");
var factory = new CharacterFactory();
string document = "AABBBCCDA";
foreach (char c in document)
{
    Character character = factory.GetCharacter(c);
    character.Display();
}


// Proxy Pattern
Console.WriteLine("\nProxy Pattern:");
IImage image = new ImageProxy("example.jpg");
image.Display();
image.Display();


// Bridge Pattern
Console.WriteLine("\nBridge Pattern:");
IRenderer vectorRenderer = new VectorRenderer();
IRenderer rasterRenderer = new RasterRenderer();
Shape vectorCircle = new Circle(vectorRenderer, 5);
Shape rasterCircle = new Circle(rasterRenderer, 10);
vectorCircle.Draw();
rasterCircle.Draw();


Console.WriteLine("\nDemo complete. Press any key to exit...");
Console.ReadKey();