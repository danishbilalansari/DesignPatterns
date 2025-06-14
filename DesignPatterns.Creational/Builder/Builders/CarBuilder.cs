using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Builders;

public abstract class CarBuilder
{
    protected Car car;

    public CarBuilder CreateNewCar()
    {
        car = new Car();
        return this;
    }

    public abstract CarBuilder BuildEngine();
    public abstract CarBuilder BuildWheels();
    public abstract CarBuilder BuildDoors();
    public abstract CarBuilder BuildColor();

    public Car Build() => car;
}