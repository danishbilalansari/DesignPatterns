using DesignPatterns.Structural.Proxy.Interfaces;

namespace DesignPatterns.Structural.Proxy.RealSubject;

/// <summary>
/// RealImage class. Represents the real image object.
/// </summary>
public class RealImage : IImage
{
    private readonly string _fileName;

    /// <summary>
    /// Initializes a new instance of RealImage and loads the image from disk.
    /// </summary>
    /// <param name="fileName">The image file name.</param>
    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk();
    }

    /// <summary>
    /// Loads the image from disk.
    /// </summary>
    private void LoadFromDisk() => Console.WriteLine("Loading " + _fileName);

    /// <summary>
    /// Displays the image.
    /// </summary>
    public void Display() => Console.WriteLine("Displaying " + _fileName);
}