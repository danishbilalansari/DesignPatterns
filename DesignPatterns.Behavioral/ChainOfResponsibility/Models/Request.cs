namespace DesignPatterns.Behavioral.ChainOfResponsibility.Models;

public class Request
{
    public string Type { get; set; }
    public int Amount { get; set; }

    public Request(string type, int amount)
    {
        Type = type;
        Amount = amount;
    }
}
