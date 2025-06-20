# Design Patterns (.Net 8)

Design patterns are reusable solutions to common problems in software design. They represent best practices used to solve general design issues in a structured and efficient way. Design patterns are not ready-made code but templates that guide how to structure classes and objects to solve a problem.

# What Are Design Patterns Used For?

1. **Improve Code Reusability** – Avoid reinventing the wheel for common problems.
2. **Enhance Maintainability** – Make code easier to understand and modify.
3. **Promote Scalability** – Allow systems to grow without major redesigns.
4. **Encourage Best Practices** – Follow proven solutions instead of ad-hoc approaches.
5. **Facilitate Communication** – Provide a common vocabulary for developers.

# Types of Design Patterns
Design patterns are broadly classified into three categories based on their purpose:

![image alt](https://github.com/danishbilalansari/DesignPatterns/blob/c2c3de905127f8113f8d69c72b95bc64ea01a76d/DesignPatterns.png)

## Creational Design Patterns

Creational design patterns deal with **object creation mechanisms**, aiming to create objects in a manner suitable to the situation. They help make a system independent of how its objects are created, composed, and represented, promoting **flexibility and reuse**.

This repository contains implementations of several core creational design patterns in C#, including:

## Implemented Patterns

### Abstract Factory
- Provides an interface to create families of related or dependent objects without specifying their concrete classes.
- Used here to create platform-specific UI elements like buttons and checkboxes for Windows and Mac.

### Builder
- Separates the construction of a complex object from its representation, allowing the same construction process to create different representations.
- Useful when building complex objects with many possible configurations.

### Factory Method
- Defines an interface for creating an object but lets subclasses decide which class to instantiate.
- Decouples client code from concrete implementations.
> Example: A `VehicleFactory` creating `Car` or `Bike` objects based on input.

### Prototype
- Creates new objects by copying an existing object (prototype) rather than constructing new instances from scratch.
- The prototype interface defines the Clone method, and concrete prototypes implement the cloning logic.
- Useful when object creation is expensive, and you need to replicate objects efficiently.

### Singleton
- Ensures a class has only one instance and provides a global point of access to it.
- Thread-safe and lazily initialized.
- Useful for shared resources like configuration or logging.

## Project Structure - Creational

<pre lang="text"><code>
DesignPatterns.Creational/
├── AbstractFactory/
│  ├── Factories/
│  │  ├── IGUIFactory.cs
│  │  ├── MacFactory.cs
│  │  └── WindowsFactory.cs
│  ├── Products/  
│  │  ├── Buttons/
│  │  │  ├── IButton.cs
│  │  │  ├── MacButton.cs
│  │  │  └── WindowsCheckbox.cs
│  │  ├── Checkboxes/
│  │  │  ├── ICheckbox.cs
│  │  │  ├── MacCheckbox.cs
│  │  │  └── WindowsCheckbox.cs
├── Builder/
│  ├── Builders/
│  │  ├── CarBuilder.cs
│  │  └── SportsBuilder.cs
│  ├── Models/
│  │  └── Car.cs
├── FactoryMethod/
│  ├── Interfaces/
│  │  └── IVehicle.cs
│  ├── Implementation/
│  │  ├── Car.cs
│  │  └── Bike.cs
│  └── VehicleFactory.cs
├── Prototype/
│  ├── Clients/
│  │  └── Client.cs
│  ├── Models/
│  │  ├── ConcreteProduct.cs
│  │  └── Product.cs
├── Singleton/
│  └── Singleton.cs
│
DesignPatterns.Demo/
│  └── Program.cs
</code></pre>

## Structural Design Patterns

Structural design patterns focus on how classes and objects are composed to form larger structures, while keeping the system flexible and efficient. These patterns help ensure parts of a system can work together smoothly even as individual components evolve independently.

This repository contains implementations of several core structural design patterns in C#, including:

## Implemented Patterns

### Adapter
- Converts the interface of a class into another interface clients expect.
- Allows incompatible interfaces to work together without changing their source code.
> Example: A `LoggerAdapter` allows integration of an `OldLogger` into a modern logging interface.

### Bridge
- Decouples an abstraction from its implementation so the two can vary independently.
- Useful when both the abstraction and its implementation are expected to change frequently.
> Example: A `Circle` shape can be rendered using different strategies like `VectorRenderer` or `RasterRenderer`.

### Composite
- Composes objects into tree structures to represent part-whole hierarchies.
- Allows clients to treat individual objects and groups of objects uniformly.
> Example: A `Folder` can contain both `File` objects and other `Folder` objects, enabling recursive operations.

### Decorator
- Attaches additional responsibilities to an object dynamically.
- Provides a flexible alternative to subclassing for extending behavior.
> Example: A `EmailNotifier` can be decorated with an `SMSDecorator` to send both email and SMS notifications.

### Facade
- Provides a simplified, unified interface to a set of interfaces in a subsystem.
- Helps reduce complexity and dependencies in client code.
> Example: A `MediaFacade` abstracts the use of `AudioSystem` and `VideoSystem` into a single `PlayMedia()` method.

### Flyweight
- Reduces memory usage by sharing common parts of objects that are repeated multiple times.
- Useful when dealing with a large number of similar objects.
> Example: A `CharacterFactory` ensures characters like 'A' or 'B' are shared rather than created anew every time.

### Proxy
- Provides a surrogate or placeholder for another object to control access to it.
- Can add lazy loading, access control, logging, and more.
> Example: An `ImageProxy` defers loading of a `RealImage` until the image is actually needed.

## Project Structure - Structural

<pre lang="text"><code>
DesignPatterns.Structural/
├── Adapter/
│  ├── Interfaces/
│  │  └── INewLogger.cs
│  ├── Legacy/
│  │  └── OldLogger.cs
│  └── Adapters/
│  │  └── LoggerAdapter.cs
├── Bridge/
│  ├── Abstractions/
│  │  ├── Shape.cs
│  │  └── Circle.cs
│  └── Implementations/
│  │  ├── IRenderer.cs
│  │  ├── VectorRenderer.cs
│  │  └── RasterRenderer.cs
├── Composite/
│  ├── Interfaces/
│  │  └── IComponent.cs
│  ├── Leaf/
│  │  └── File.cs
│  ├── Composite/
│  │  └── Folder.cs
├── Decorator/
│  ├── Components/
│  │  └── INotifier.cs
│  ├── ConcreteComponents/
│  │  └── EmailNotifier.cs
│  ├── Decorators/
│  │  └── SMSDecorator.cs
├── Facade/
│  ├── Subsystems/
│  │  ├── AudioSystem.cs
│  │  └── VideoSystem.cs
│  ├── Facade/
│  │  └── MediaFacade.cs
├── Flyweight/
│  ├── Flyweights/
│  │  └── Character.cs
│  ├── Factory/
│  │  └── CharacterFactory.cs
├── Proxy/
│  ├── Interfaces/
│  │  └── IImage.cs
│  ├── RealSubject/
│  │  └── RealImage.cs
│  ├── Proxy/
│  │  └── ImageProxy.cs
│
DesignPatterns.Demo/
│  └── Program.cs
</code></pre>

## Behavioral Design Patterns

Behavioral design patterns focus on the interaction and responsibility between objects. These patterns help ensure that objects communicate in a flexible and maintainable way, reducing tight coupling and improving scalability.

This repository contains implementations of several core behavioral design patterns in C#, including:

## Implemented Patterns

### Strategy
- Encapsulates interchangeable algorithms or behaviors and selects them at runtime.
> Example: Sort integers using `BubbleSort` or `QuickSort` dynamically.

### Observer
- Defines a one-to-many relationship so that when one object changes state, all dependents are notified automatically.
> Example: A `WeatherStation` notifying `PhoneDisplay` and `TVDisplay`.

### Command
- Encapsulates requests as objects, allowing parameterization, queuing, and logging of operations.
> Example: `RemoteControl` triggering `LightOnCommand` and `LightOffCommand`.

### Chain of Responsibility
- Passes a request along a chain of handlers until one of them handles it.
> Example: A request passes through `Authentication`, `Logging`, and `Validation` handlers.

### Interpreter
- Defines a grammar and an interpreter to process that grammar.
> Example: Arithmetic expression evaluator using nested expression trees.

### Iterator
- Provides a standard way to access elements of a collection sequentially.
> Example: A `NameRepository` exposes names using an internal `NameIterator`.

### Mediator
- Defines an object that centralizes complex communications and control between related objects.
> Example: `ChatMediator` manages messaging between `ChatUser` instances.

### Memento
- Captures and restores an object's internal state without violating encapsulation.
> Example: `TextEditor` saves and restores its content using `EditorMemento`.

### State
- Allows an object to change its behavior when its internal state changes.
> Example: `Context` transitions between `StartState` and `StopState`.

### Template Method
- Defines the structure of an algorithm but lets subclasses redefine specific steps.
> Example: `Game` base class with `Football` and `Chess` subclasses defining steps.

### Visitor
- Separates operations from the objects on which they operate.
> Example: `PriceCalculatorVisitor` visits `Book` and `Fruit` elements to calculate total cost.

## Project Structure - Behavioral

<pre lang="text"><code>
DesignPatterns.Behavioral/
├── ChainOfResponsibility/
│  ├── Handlers/
│  │  ├── Handler.cs
│  │  ├── AuthenticationHandler.cs
│  │  ├── LoggingHandler.cs
│  │  └── ValidationHandler.cs
├── Command/
│  ├── Commands/
│  │  ├── ICommand.cs
│  │  ├── LightOnCommand.cs
│  │  └── LightOffCommand.cs
│  ├── Receivers/
│  │  └── Light.cs
│  ├── Invokers/
│  │  └── RemoteControl.cs
├── Interpreter/
│  ├── Expressions/
│  │  ├── IExpression.cs
│  │  ├── NumberExpression.cs
│  │  └── AddExpression.cs
├── Iterator/
│  ├── Aggregates/
│  │  └── NameRepository.cs
│  ├── Iterators/
│  │  ├── IIterator.cs
│  │  └── NameIterator.cs
├── Mediator/
│  ├── Mediators/
│  │  └── ChatMediator.cs
│  ├── Components/
│  │  ├── ChatUser.cs
│  │  └── IUser.cs
├── Memento/
│  ├── Originator/
│  │  └── TextEditor.cs
│  ├── Memento/
│  │  └── EditorMemento.cs
│  └── Caretaker/
│  │  └── History.cs
├── Observer/
│  ├── Subjects/
│  │  └── WeatherStation.cs
│  └── Observers/
│  │  ├── IObserver.cs
│  │  ├── PhoneDisplay.cs
│  │  └── TVDisplay.cs
├── State/
│  ├── Context/
│  │  └── Context.cs
│  └── States/
│  │  ├── IState.cs
│  │  ├── StartState.cs
│  │  └── StopState.cs
├── Strategy/
│  ├── Strategies/
│  │  ├── ISortStrategy.cs
│  │  ├── BubbleSortStrategy.cs
│  │  └── QuickSortStrategy.cs
│  ├── Context/
│  │  └── ContextStrategy.cs
├── TemplateMethod/
│  ├── Abstract/
│  │  └── Game.cs
│  ├── Concrete/
│  │  ├── Football.cs
│  │  └── Chess.cs
├── Visitor/
│  ├── Elements/
│  │  ├── IElement.cs
│  │  ├── Book.cs
│  │  └── Fruit.cs
│  ├── Visitors/
│  │  ├── IVisitor.cs
│  │   └── PriceCalculatorVisitor.cs
│
DesignPatterns.Demo/
│  └── Program.cs
</code></pre>


## Design Patterns - Unit Tests

The DesignPatterns.Tests project contains comprehensive unit tests for all implemented Creational, Structural, and Behavioral design patterns in the solution. These tests ensure each pattern behaves as expected under various scenarios and validates their adherence to the design principles they're meant to demonstrate.

## Project Structure - Tests

<pre lang="text"><code>
DesignPatterns.Tests/
├── Behavioral/
│  ├── ChainOfResponsibilityTests.cs
│  ├── CommandTests.cs
│  ├── InterpreterTests.cs
│  ├── IteratorTests.cs
│  ├── MediatorTests.cs
│  ├── MementoTests.cs
│  ├── ObserverTests.cs
│  ├── StateTests.cs
│  ├── StrategyTests.cs
│  ├── TemplateMethodTests.cs
│  └── VisitorTests.cs
│ 
├── Creational/
│  ├── AbstractFactoryTests.cs
│  ├── BuilderTests.cs
│  ├── FactoryMethodTests.cs
│  ├── PrototypeTests.cs
│  └── SingletonTests.cs
│ 
├── Structural/
│  ├── AdapterTests.cs
│  ├── BridgeTests.cs
│  ├── CompositeTests.cs
│  ├── DecoratorTests.cs
│  ├── FacadeTests.cs
│  ├── FlyweightTests.cs
│  └── ProxyTests.cs
│ 
├── BaseTest.cs
</code></pre>

- Each pattern has its corresponding file that contains focused unit tests for its components and flow.
- Additionally, a shared **BaseTest.cs** file is an abstract test base class that ensures all derived tests run sequentially by assigning them to a non-parallel xUnit collection. This prevents shared resource conflicts and race conditions during test execution.

## Purpose of Tests
- **Verify behavior:** Ensure the design pattern behaves correctly in isolation.
- **Validate interactions:** Especially for behavioral patterns like Observer, Command, Mediator, and Strategy, which involve multiple components interacting.
- **Catch regressions:** Quickly identify when changes break expected behavior.
- **Educate:** Provide executable examples of how each pattern works in a real-world scenario.

<!--
## Usage

A console application project (`DesignPatterns.Demo`) references this library and provides an interactive demonstration:

- Demonstrates the Singleton pattern with a global instance.
- Prompts for vehicle type to demonstrate Factory Method.
- Prompts for UI platform to demonstrate Abstract Factory.
-->

## How to Run Demo

1. Clone the repository.
2. Build the solution.
3. Run the `DesignPatterns.Demo` console project.
4. Follow the interactive prompts in the console.
