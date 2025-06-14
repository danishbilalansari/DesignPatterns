namespace DesignPatterns.Creational.Builder.Builders;

public class SportsCarBuilder : CarBuilder
{
    public override CarBuilder BuildEngine()
    {
        car.Engine = "V8";
        return this;
    }

    public override CarBuilder BuildWheels()
    {
        car.Wheels = "Sporty Wheels";
        return this;
    }

    public override CarBuilder BuildDoors()
    {
        car.Doors = "2 Doors";
        return this;
    }

    public override CarBuilder BuildColor()
    {
        car.Color = "Red";
        return this;
    }
}