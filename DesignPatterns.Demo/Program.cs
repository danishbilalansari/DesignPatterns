// Behavioral Patterns
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

// Creational Patterns
using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Models;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.Interfaces;
using DesignPatterns.Creational.Prototype.Clients;
using DesignPatterns.Creational.Prototype.Models;
using DesignPatterns.Creational.Singleton;

// Structural Patterns
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

// Alias for LeafFile
using LeafFile = DesignPatterns.Structural.Composite.Leaf.File;

class Program
{
    static void ExecuteCreationalPattern(int choice)
    {
        switch (choice)
        {
            case 1: // Abstract Factory
                Console.WriteLine("\nAbstract Factory Pattern");
                // Abstract Factory Code
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
                break;

            case 2: // Builder
                Console.WriteLine("\nBuilder Pattern");
                // Builder Code
                CarBuilder builder = new SportsCarBuilder();
                Car car = builder.CreateNewCar()
                                 .BuildEngine()
                                 .BuildWheels()
                                 .BuildDoors()
                                 .BuildColor()
                                 .Build();
                car.ShowDetails();
                break;

            case 3: // Factory Method
                Console.WriteLine("\nFactory Method Pattern");
                // Factory Method Code
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
                break;

            case 4: // Prototype
                Console.WriteLine("\nPrototype Pattern");
                // Prototype Code
                Product product1 = new ConcreteProduct("Laptop", "Electronics");
                Console.WriteLine("Original Product:");
                product1.ShowDetails();
                ((ConcreteProduct)product1).ShowCategory();
                Client client = new Client(product1);
                Product clonedProduct = client.GetClone();
                Console.WriteLine("Cloned Product:");
                clonedProduct.ShowDetails();
                ((ConcreteProduct)clonedProduct).ShowCategory();
                break;

            case 5: // Singleton
                Console.WriteLine("\nSingleton Pattern");
                // Singleton Code
                var singleton1 = Singleton.Instance;
                var singleton2 = Singleton.Instance;
                singleton1.DoSomething();
                Console.WriteLine($"Is singleton1 same as singleton2? {ReferenceEquals(singleton1, singleton2)}");
                break;

            default:
                Console.WriteLine("Invalid choice. Please enter a valid number.");
                break;
        }
    }

    static void ExecuteStructuralPattern(int choice)
    {
        switch (choice)
        {
            case 1: // Adapter
                Console.WriteLine("\nAdapter Pattern");
                // Adapter Code
                INewLogger logger = new LoggerAdapter();
                logger.Log("Adapter Pattern in action!");
                break;

            case 2: // Bridge
                Console.WriteLine("\nBridge Pattern");
                // Bridge Code
                IRenderer vectorRenderer = new VectorRenderer();
                IRenderer rasterRenderer = new RasterRenderer();
                Shape vectorCircle = new Circle(vectorRenderer, 5);
                Shape rasterCircle = new Circle(rasterRenderer, 10);
                vectorCircle.Draw();
                rasterCircle.Draw();
                break;

            case 3: // Composite
                Console.WriteLine("\nComposite Pattern");
                // Composite Code
                var root = new Folder("Root");
                root.Add(new LeafFile("File1.txt"));
                root.Add(new LeafFile("File2.txt"));
                var sub = new Folder("SubFolder");
                sub.Add(new LeafFile("File3.txt"));
                root.Add(sub);
                root.Display(1);
                break;

            case 4: // Decorator
                Console.WriteLine("\nDecorator Pattern");
                // Decorator Code
                INotifier notifier = new EmailNotifier();
                notifier = new SMSDecorator(notifier);
                notifier.Send("You have a new notification");
                break;

            case 5: // Facade
                Console.WriteLine("\nFacade Pattern");
                // Facade Code
                var mediaFacade = new MediaFacade();
                mediaFacade.PlayMedia();
                break;

            case 6: // Flyweight
                Console.WriteLine("\nFlyweight Pattern");
                // Flyweight Code
                var factory = new CharacterFactory();
                string document = "AABBBCCDA";
                foreach (char c in document)
                {
                    Character character = factory.GetCharacter(c);
                    character.Display();
                }
                break;

            case 7: // Proxy
                Console.WriteLine("\nProxy Pattern");
                // Proxy Code
                IImage image = new ImageProxy("example.jpg");
                image.Display();
                image.Display();
                break;

            default:
                Console.WriteLine("Invalid choice. Please enter a valid number.");
                break;
        }
    }

    static void ExecuteBehavioralPattern(int choice)
    {
        switch (choice)
        {
            case 1: // Chain of Responsibility
                Console.WriteLine("\nChain of Responsibility Pattern");
                // Chain of Responsibility Code
                var manager = new Manager();
                var director = new Director();
                manager.SetNext(director);
                var request1 = new Request("Purchase", 500);
                var request2 = new Request("Purchase", 5000);
                var request3 = new Request("Purchase", 15000);
                manager.Handle(request1);
                manager.Handle(request2);
                manager.Handle(request3);
                break;

            case 2: // Command
                Console.WriteLine("\nCommand Pattern");
                // Command Code
                var receiver = new Light();
                var onCommand = new LightOnCommand(receiver);
                var offCommand = new LightOffCommand(receiver);
                var remote = new RemoteControl();
                remote.SetCommand(onCommand);
                remote.PressButton();
                remote.SetCommand(offCommand);
                remote.PressButton();
                break;

            case 3: // Interpreter
                Console.WriteLine("\nInterpreter Pattern");
                // Interpreter Code
                IExpression expr = new AddExpression(new NumberExpression(5), new NumberExpression(3));
                Console.WriteLine($"Result of expression: {expr.Interpret()}");
                break;

            case 4: // Iterator
                Console.WriteLine("\nIterator Pattern");
                // Iterator Code
                var nameRepo = new NameRepository();
                var iterator = nameRepo.CreateIterator();
                while (iterator.HasNext())
                {
                    Console.WriteLine(iterator.Next());
                }
                break;

            case 5: // Mediator
                Console.WriteLine("\nMediator Pattern");
                // Mediator Code
                var mediator = new ChatMediator();
                var user1 = new User("Alice", mediator);
                var user2 = new User("Bob", mediator);
                mediator.AddUser(user1);
                mediator.AddUser(user2);
                user1.Send("Hello Bob!");
                user2.Send("Hi Alice!");
                break;

            case 6: // Memento
                Console.WriteLine("\nMemento Pattern");
                // Memento Code
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
                break;

            case 7: // Observer
                Console.WriteLine("\nObserver Pattern");
                // Observer Code
                var weatherStation = new WeatherStation();
                var phone = new PhoneDisplay();
                var window = new WindowDisplay();
                weatherStation.Register(phone);
                weatherStation.Register(window);
                weatherStation.SetTemperature(25.5f);
                weatherStation.SetTemperature(30.2f);
                break;

            case 8: // State
                Console.WriteLine("\nState Pattern");
                // State Code
                var stateContext = new Context();
                stateContext.SetState(new StartState());
                stateContext.SetState(new StopState());
                break;

            case 9: // Strategy
                Console.WriteLine("\nStrategy Pattern");
                // Strategy Code
                var strategyContext = new CompressionContext();
                strategyContext.SetStrategy(new ZipCompression());
                strategyContext.CompressFile("report.docx");
                strategyContext.SetStrategy(new RarCompression());
                strategyContext.CompressFile("archive.tar");
                break;

            case 10: // Template Method
                Console.WriteLine("\nTemplate Method Pattern");
                // Template Method Code
                var football = new Football();
                football.Play();
                Console.WriteLine();
                var chess = new Chess();
                chess.Play();
                break;

            case 11: // Visitor
                Console.WriteLine("\nVisitor Pattern");
                // Visitor Code
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
                break;

            default:
                Console.WriteLine("Invalid choice. Please enter a valid number.");
                break;
        }
    }

    static void Main(string[] args)
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Select a category:");
            Console.WriteLine("1. Creational Patterns");
            Console.WriteLine("2. Structural Patterns");
            Console.WriteLine("3. Behavioral Patterns");
            Console.WriteLine("0. Exit");

            int categoryChoice = Convert.ToInt32(Console.ReadLine());

            switch (categoryChoice)
            {
                case 1: // Creational Patterns
                    Console.WriteLine("\nSelect a pattern from the Creational Patterns:");
                    Console.WriteLine("1. Abstract Factory");
                    Console.WriteLine("2. Builder");
                    Console.WriteLine("3. Factory Method");
                    Console.WriteLine("4. Prototype");
                    Console.WriteLine("5. Singleton");
                    Console.WriteLine("0. Exit");
                    int creationalChoice = Convert.ToInt32(Console.ReadLine());
                    ExecuteCreationalPattern(creationalChoice);
                    break;

                case 2: // Structural Patterns
                    Console.WriteLine("\nSelect a pattern from the Structural Patterns:");
                    Console.WriteLine("1. Adapter");
                    Console.WriteLine("2. Bridge");
                    Console.WriteLine("3. Composite");
                    Console.WriteLine("4. Decorator");
                    Console.WriteLine("5. Facade");
                    Console.WriteLine("6. Flyweight");
                    Console.WriteLine("7. Proxy");
                    Console.WriteLine("0. Exit");
                    int structuralChoice = Convert.ToInt32(Console.ReadLine());
                    ExecuteStructuralPattern(structuralChoice);
                    break;

                case 3: // Behavioral Patterns
                    Console.WriteLine("\nSelect a pattern from the Behavioral Patterns:");
                    Console.WriteLine("1. Chain of Responsibility");
                    Console.WriteLine("2. Command");
                    Console.WriteLine("3. Interpreter");
                    Console.WriteLine("4. Iterator");
                    Console.WriteLine("5. Mediator");
                    Console.WriteLine("6. Memento");
                    Console.WriteLine("7. Observer");
                    Console.WriteLine("8. State");
                    Console.WriteLine("9. Strategy");
                    Console.WriteLine("10. Template Method");
                    Console.WriteLine("11. Visitor");
                    Console.WriteLine("0. Exit");
                    int behavioralChoice = Convert.ToInt32(Console.ReadLine());
                    ExecuteBehavioralPattern(behavioralChoice);
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    continueProgram = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Exiting...");
                    continueProgram = false;
                    break;
            }

            // Ask if the user wants to try another pattern
            if (continueProgram)
            {
                Console.WriteLine("\nWould you like to try another pattern? (Y/N)");
                string? userChoice = Console.ReadLine()?.ToLower();
                if (!userChoice!.Equals("y"))
                {
                    Console.WriteLine("Exiting...");
                    continueProgram = false;
                }
            }
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
