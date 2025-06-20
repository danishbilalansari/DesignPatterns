namespace DesignPatterns.Creational.Builder.Models;

/// <summary>
/// Car class. Represents the product being built.
/// </summary>
public class Car
{
    public string Engine { get; set; }
    public string Wheels { get; set; }
    public string Doors { get; set; }
    public string Color { get; set; }

    /// <summary>
    /// Shows the details of the car.
    /// </summary>
    public void ShowDetails()
    {
        Console.WriteLine($"Engine: {Engine}, Wheels: {Wheels}, Doors: {Doors}, Color: {Color}");
    }
}