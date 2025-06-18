using DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteHandlers;
using DesignPatterns.Behavioral.ChainOfResponsibility.Models;
using DesignPatterns.Behavioral.Command.Commands;
using DesignPatterns.Behavioral.Command.Invoker;
using DesignPatterns.Behavioral.Command.Receiver;
using DesignPatterns.Behavioral.Interpreter.Expressions;
using DesignPatterns.Behavioral.Interpreter.Interfaces;
using DesignPatterns.Behavioral.Iterator.Concrete;
using DesignPatterns.Behavioral.Mediator.Concrete;
using DesignPatterns.Behavioral.Memento.Caretaker;
using DesignPatterns.Behavioral.Memento.Originator;
using DesignPatterns.Behavioral.Observer.Observers;
using DesignPatterns.Behavioral.Observer.Subjects;
using DesignPatterns.Behavioral.State.Context;
using DesignPatterns.Behavioral.State.States;
using DesignPatterns.Behavioral.Strategy.Context;
using DesignPatterns.Behavioral.Strategy.Strategies;
using DesignPatterns.Behavioral.TemplateMethod.Concrete;
using DesignPatterns.Behavioral.Visitor.Elements;
using DesignPatterns.Behavioral.Visitor.Visitors;
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

void DisplayHeader(string patternName)
{
    Console.WriteLine($"{patternName}");
    Console.WriteLine(new string('=', patternName.Length));
}

// Abstract Factory Pattern
DisplayHeader("Abstract Factory Pattern");
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
DisplayHeader("Builder Pattern");
CarBuilder builder = new SportsCarBuilder();
Car car = builder.CreateNewCar()
                 .BuildEngine()
                 .BuildWheels()
                 .BuildDoors()
                 .BuildColor()
                 .Build();
car.ShowDetails();


// Factory Method Pattern
DisplayHeader("Factory Method Pattern");
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


// Prototype Pattern
DisplayHeader("Prototype Pattern");
Product product1 = new ConcreteProduct("Laptop", "Electronics");
Console.WriteLine("Original Product:");
product1.ShowDetails();
((ConcreteProduct)product1).ShowCategory();
Client client = new Client(product1);
Product clonedProduct = client.GetClone();
Console.WriteLine("Cloned Product:");
clonedProduct.ShowDetails();
((ConcreteProduct)clonedProduct).ShowCategory();


// Singleton Pattern
DisplayHeader("Singleton Pattern");
var singleton1 = Singleton.Instance;
var singleton2 = Singleton.Instance;
singleton1.DoSomething();
Console.WriteLine($"Is singleton1 same as singleton2? {ReferenceEquals(singleton1, singleton2)}");


// Adapter Pattern
DisplayHeader("Adapter Pattern");
INewLogger logger = new LoggerAdapter();
logger.Log("Adapter Pattern in action!");


// Bridge Pattern
DisplayHeader("Bridge Pattern");
IRenderer vectorRenderer = new VectorRenderer();
IRenderer rasterRenderer = new RasterRenderer();
Shape vectorCircle = new Circle(vectorRenderer, 5);
Shape rasterCircle = new Circle(rasterRenderer, 10);
vectorCircle.Draw();
rasterCircle.Draw();


// Composite Pattern
DisplayHeader("Composite Pattern");
var root = new Folder("Root");
root.Add(new LeafFile("File1.txt"));
root.Add(new LeafFile("File2.txt"));
var sub = new Folder("SubFolder");
sub.Add(new LeafFile("File3.txt"));
root.Add(sub);
root.Display(1);


// Decorator Pattern
DisplayHeader("Decorator Pattern");
INotifier notifier = new EmailNotifier();
notifier = new SMSDecorator(notifier);
notifier.Send("You have a new notification");


// Facade Pattern
DisplayHeader("Facade Pattern");
var mediaFacade = new MediaFacade();
mediaFacade.PlayMedia();


// Flyweight Pattern
DisplayHeader("Flyweight Pattern");
var factory = new CharacterFactory();
string document = "AABBBCCDA";
foreach (char c in document)
{
    Character character = factory.GetCharacter(c);
    character.Display();
}

// Proxy Pattern
DisplayHeader("Proxy Pattern");
IImage image = new ImageProxy("example.jpg");
image.Display();
image.Display();

// Chain of Responsibility Pattern
DisplayHeader("Chain of Responsibility Pattern");
var manager = new Manager();
var director = new Director();
manager.SetNext(director);
var request1 = new Request("Purchase", 500);
var request2 = new Request("Purchase", 5000);
var request3 = new Request("Purchase", 15000);
manager.Handle(request1);
manager.Handle(request2);
manager.Handle(request3);


// Command Pattern
DisplayHeader("Command Pattern");
var receiver = new Light();
var onCommand = new LightOnCommand(receiver);
var offCommand = new LightOffCommand(receiver);
var remote = new RemoteControl();
remote.SetCommand(onCommand);
remote.PressButton();
remote.SetCommand(offCommand);
remote.PressButton();
Console.WriteLine();


// Interpreter Pattern
DisplayHeader("Interpreter Pattern");
IExpression expr = new AddExpression(new NumberExpression(5), new NumberExpression(3));
Console.WriteLine($"Result of expression: {expr.Interpret()}");
Console.WriteLine();


// Iterator Pattern
DisplayHeader("Iterator Pattern");
var nameRepo = new NameRepository();
var iterator = nameRepo.CreateIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}


// Mediator Pattern
DisplayHeader("Mediator Pattern");
var mediator = new ChatMediator();
var user1 = new User("Alice", mediator);
var user2 = new User("Bob", mediator);
mediator.AddUser(user1);
mediator.AddUser(user2);
user1.Send("Hello Bob!");
user2.Send("Hi Alice!");
Console.WriteLine();

// Memento Pattern
DisplayHeader("Memento Pattern");
var editor = new TextEditor();
var history = new History();
editor.Content = "Version 1";
history.Push(editor.Save());
editor.Content = "Version 2";
history.Push(editor.Save());
editor.Content = "Version 3";
Console.WriteLine($"Current: {editor.Content}");
editor.Restore(history.Pop());
Console.WriteLine($"After Undo: {editor.Content}");
editor.Restore(history.Pop());
Console.WriteLine($"After Undo: {editor.Content}");
Console.WriteLine();


// Observer Pattern
DisplayHeader("Observer Pattern");
var weatherStation = new WeatherStation();
var phone = new PhoneDisplay();
var window = new WindowDisplay();
weatherStation.Register(phone);
weatherStation.Register(window);
weatherStation.SetTemperature(25.5f);
weatherStation.SetTemperature(30.2f);


// State Pattern
DisplayHeader("State Pattern");
var stateContext = new Context();
stateContext.SetState(new StartState());
stateContext.SetState(new StopState());
Console.WriteLine();


// Strategy Pattern
DisplayHeader("Strategy Pattern");
var strategyContext = new CompressionContext();
strategyContext.SetStrategy(new ZipCompression());
strategyContext.CompressFile("report.docx");
strategyContext.SetStrategy(new RarCompression());
strategyContext.CompressFile("archive.tar");


// Template Method Pattern
DisplayHeader("Template Method Pattern");
var football = new Football();
football.Play();
Console.WriteLine();
var chess = new Chess();
chess.Play();


// Visitor Pattern
DisplayHeader("Visitor Pattern");
List<IElement> items = new()
{
    new Book("Design Patterns", 50),
    new Fruit("Apple", 2, 3),
    new Book("Refactoring", 45),
    new Fruit("Banana", 1.5, 2)
};
var visitor = new PriceCalculatorVisitor();
foreach (var item in items)
{
    item.Accept(visitor);
}


Console.WriteLine("\nDesign patterns demo complete. Press any key to exit...");
Console.ReadKey();
