using DesignPatterns.Behavioral.ChainOfResponsibility.AbstractHandlers;
using DesignPatterns.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteHandlers;

/// <summary>
/// Manager class. Handles requests below a certain threshold or passes to the next handler.
/// </summary>
public class Manager : Handler
{
    /// <summary>
    /// Handles the request if amount is less than 1000, otherwise passes to next handler.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    public override void Handle(Request request)
    {
        if (request.Amount < 1000)
            Console.WriteLine($"Manager approved request of {request.Amount}.");
        else
            Next?.Handle(request);
    }
}
