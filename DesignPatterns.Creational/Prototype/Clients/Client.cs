using DesignPatterns.Creational.Prototype.Models;

namespace DesignPatterns.Creational.Prototype.Clients;

public class Client
{
    private Product _prototype;

    public Client(Product prototype)
    {
        _prototype = prototype;
    }

    public Product GetClone()
    {
        return _prototype.Clone();
    }
}