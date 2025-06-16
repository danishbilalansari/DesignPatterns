using DesignPatterns.Structural.Proxy.Interfaces;
using DesignPatterns.Structural.Proxy.RealSubject;

namespace DesignPatterns.Structural.Proxy.Proxy;

public class ImageProxy : IImage
{
    private RealImage _realImage;
    private readonly string _fileName;

    public ImageProxy(string fileName)
    {
        _fileName = fileName;
    }

    public void Display()
    {
        _realImage ??= new RealImage(_fileName);
        _realImage.Display();
    }
}