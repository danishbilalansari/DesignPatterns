using DesignPatterns.Behavioral.ChainOfResponsibility.AbstractHandlers;
using DesignPatterns.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteHandlers;

public class Director : Handler
{
    public override void Handle(Request request)
    {
        if (request.Amount < 10000)
            Console.WriteLine($"Director approved request of {request.Amount}.");
        else
            Console.WriteLine("Request denied. Amount too high.");
    }
}
