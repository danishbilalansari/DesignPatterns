# Design Patterns

# Creational Design Patterns

Creational design patterns deal with **object creation mechanisms**, aiming to create objects in a manner suitable to the situation. They help make a system independent of how its objects are created, composed, and represented, promoting **flexibility and reuse**.

This repository contains implementations of several core creational design patterns in C#, including:

---

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

---

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

