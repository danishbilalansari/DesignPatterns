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
- Example: A `VehicleFactory` creating `Car` or `Bike` objects based on input.

### Prototype
- Creates new objects by copying an existing object (prototype) rather than constructing new instances from scratch.
- The prototype interface defines the Clone method, and concrete prototypes implement the cloning logic.
- Useful when object creation is expensive, and you need to replicate objects efficiently.

### Singleton
- Ensures a class has only one instance and provides a global point of access to it.
- Thread-safe and lazily initialized.
- Useful for shared resources like configuration or logging.

## Structural Design Patterns

Structural design patterns focus on how classes and objects are composed to form larger structures, while keeping the system flexible and efficient. These patterns help ensure parts of a system can work together smoothly even as individual components evolve independently.

This repository contains implementations of several core structural design patterns in C#, including:

## Implemented Patterns

### Adapter
- Converts the interface of a class into another interface clients expect.
- Allows incompatible interfaces to work together without changing their source code.
- Example: A `LoggerAdapter` allows integration of an `OldLogger` into a modern logging interface.

### Bridge
- Decouples an abstraction from its implementation so the two can vary independently.
- Useful when both the abstraction and its implementation are expected to change frequently.
- Example: A `Circle` shape can be rendered using different strategies like `VectorRenderer` or `RasterRenderer`.

### Composite
- Composes objects into tree structures to represent part-whole hierarchies.
- Allows clients to treat individual objects and groups of objects uniformly.
- Example: A `Folder` can contain both `File` objects and other `Folder` objects, enabling recursive operations.

### Decorator
- Attaches additional responsibilities to an object dynamically.
- Provides a flexible alternative to subclassing for extending behavior.
- Example: A `EmailNotifier` can be decorated with an `SMSDecorator` to send both email and SMS notifications.

### Facade
- Provides a simplified, unified interface to a set of interfaces in a subsystem.
- Helps reduce complexity and dependencies in client code.
- Example: A `MediaFacade` abstracts the use of `AudioSystem` and `VideoSystem` into a single `PlayMedia()` method.

### Flyweight
- Reduces memory usage by sharing common parts of objects that are repeated multiple times.
- Useful when dealing with a large number of similar objects.
- Example: A `CharacterFactory` ensures characters like 'A' or 'B' are shared rather than created anew every time.

### Proxy
- Provides a surrogate or placeholder for another object to control access to it.
- Can add lazy loading, access control, logging, and more.
- Example: An `ImageProxy` defers loading of a `RealImage` until the image is actually needed.

## Project Structure

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
