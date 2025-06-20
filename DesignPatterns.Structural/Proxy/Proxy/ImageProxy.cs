using DesignPatterns.Structural.Proxy.Interfaces;
using DesignPatterns.Structural.Proxy.RealSubject;

namespace DesignPatterns.Structural.Proxy.Proxy;

/// <summary>
/// ImageProxy class. Proxy for RealImage, controls access and lazy loading.
/// </summary>
public class ImageProxy : IImage
{
    private RealImage _realImage;
    private readonly string _fileName;

    /// <summary>
    /// Initializes a new instance of ImageProxy.
    /// </summary>
    /// <param name="fileName">The image file name.</param>
    public ImageProxy(string fileName)
    {
        _fileName = fileName;
    }

    /// <summary>
    /// Displays the image, loading it if necessary.
    /// </summary>
    public void Display()
    {
        _realImage ??= new RealImage(_fileName);
        _realImage.Display();
    }
}