using DesignPatterns.Structural.Proxy.Interfaces;

namespace DesignPatterns.Structural.Proxy.RealSubject;

public class RealImage : IImage
{
    private readonly string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk();
    }

    private void LoadFromDisk() => Console.WriteLine("Loading " + _fileName);

    public void Display() => Console.WriteLine("Displaying " + _fileName);
}