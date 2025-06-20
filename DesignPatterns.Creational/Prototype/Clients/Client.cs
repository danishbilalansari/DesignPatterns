using DesignPatterns.Creational.Prototype.Models;

namespace DesignPatterns.Creational.Prototype.Clients;

/// <summary>
/// Client class. Uses a prototype to create clones.
/// </summary>
public class Client
{
    private Product _prototype;

    /// <summary>
    /// Initializes a new instance of Client with a prototype.
    /// </summary>
    /// <param name="prototype">The prototype product.</param>
    public Client(Product prototype)
    {
        _prototype = prototype;
    }

    /// <summary>
    /// Gets a clone of the prototype product.
    /// </summary>
    /// <returns>A new Product instance.</returns>
    public Product GetClone()
    {
        return _prototype.Clone();
    }
}