namespace DesignPatterns.Creational.Builder.Models;

public class Car
{
    public string Engine { get; set; }
    public string Wheels { get; set; }
    public string Doors { get; set; }
    public string Color { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine($"Engine: {Engine}, Wheels: {Wheels}, Doors: {Doors}, Color: {Color}");
    }
}