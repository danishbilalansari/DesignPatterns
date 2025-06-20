using DesignPatterns.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.AbstractHandlers;

/// <summary>
/// Handler abstract class. Defines the interface for handling requests and setting the next handler.
/// </summary>
public abstract class Handler
{
    protected Handler? Next;

    /// <summary>
    /// Sets the next handler in the chain.
    /// </summary>
    /// <param name="handler">The next handler.</param>
    public void SetNext(Handler handler) => Next = handler;

    /// <summary>
    /// Handles the request or passes it to the next handler.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    public abstract void Handle(Request request);
}
