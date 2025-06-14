# Design Patterns using .Net 8

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

### Singleton
- Ensures a class has only one instance and provides a global point of access to it.
- Thread-safe and lazily initialized.
- Useful for shared resources like configuration or logging.

### Factory Method
- Defines an interface for creating an object but lets subclasses decide which class to instantiate.
- Decouples client code from concrete implementations.
- Example: A `VehicleFactory` creating `Car` or `Bike` objects based on input.

### Abstract Factory
- Provides an interface to create families of related or dependent objects without specifying their concrete classes.
- Used here to create platform-specific UI elements like buttons and checkboxes for Windows and Mac.

### Builder
- Separates the construction of a complex object from its representation, allowing the same construction process to create different representations.
- Useful when building complex objects with many possible configurations.

## Project Structure

<pre lang="text"><code>
DesignPatterns.Creational/
├── Singleton/
│ └── Singleton.cs
├── FactoryMethod/
│ ├── Interfaces/
│ │ └── IVehicle.cs
│ ├── Implementation/
│ │ ├── Car.cs
│ │ └── Bike.cs
│ └── VehicleFactory.cs
├── AbstractFactory/
│ ├── Factories/
│ │ ├── IGUIFactory.cs
│ │ ├── MacFactory.cs
│ │ └── WindowsFactory.cs
│ ├── Products/  
│ │ ├── Buttons/
│ │ │ ├── IButton.cs
│ │ │ ├── MacButton.cs
│ │ │ └── WindowsCheckbox.cs
│ │ ├── Checkboxes/
│ │ │ ├── ICheckbox.cs
│ │ │ ├── MacCheckbox.cs
│ │ │ └── WindowsCheckbox.cs
</code></pre>

## Usage

A console application project (`DesignPatterns.Demo`) references this library and provides an interactive demonstration:

- Demonstrates the Singleton pattern with a global instance.
- Prompts for vehicle type to demonstrate Factory Method.
- Prompts for UI platform to demonstrate Abstract Factory.

## How to Run Demo

1. Clone the repository.
2. Build the solution.
3. Run the `DesignPatterns.Demo` console project.
4. Follow the interactive prompts in the console.
