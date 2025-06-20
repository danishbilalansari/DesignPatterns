using DesignPatterns.Behavioral.ChainOfResponsibility.AbstractHandlers;
using DesignPatterns.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteHandlers;

/// <summary>
/// Director class. Handles requests below a higher threshold or denies them.
/// </summary>
public class Director : Handler
{
    /// <summary>
    /// Handles the request if amount is less than 10000, otherwise denies it.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    public override void Handle(Request request)
    {
        if (request.Amount < 10000)
            Console.WriteLine($"Director approved request of {request.Amount}.");
        else
            Console.WriteLine("Request denied. Amount too high.");
    }
}
