using DesignPatterns.Behavioral.ChainOfResponsibility.AbstractHandlers;
using DesignPatterns.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteHandlers;

public class Manager : Handler
{
    public override void Handle(Request request)
    {
        if (request.Amount < 1000)
            Console.WriteLine($"Manager approved request of {request.Amount}.");
        else
            Next?.Handle(request);
    }
}
