using DesignPatterns.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.AbstractHandlers;

public abstract class Handler
{
    protected Handler? Next;

    public void SetNext(Handler handler) => Next = handler;

    public abstract void Handle(Request request);
}
