namespace DesignPatterns.Behavioral.ChainOfResponsibility.Models;

/// <summary>
/// Request class. Represents a request in the chain.
/// </summary>
public class Request
{
    /// <summary>
    /// Initializes a new instance of Request.
    /// </summary>
    /// <param name="type">The type of request.</param>
    /// <param name="amount">The amount of the request.</param>
    public Request(string type, int amount)
    {
        Type = type;
        Amount = amount;
    }

    public string Type { get; set; }
    public int Amount { get; set; }
}
