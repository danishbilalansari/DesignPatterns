// Singleton Pattern: Ensures a class has only one instance and provides a global point of access to it.
namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// Singleton class. Ensures only one instance exists and provides global access.
/// </summary>
public sealed class Singleton
{
    // Holds the single instance of the Singleton class
    private static Singleton? _instance;
    // Lock object for thread safety
    private static readonly object _lock = new();

    // Private constructor prevents instantiation from outside
    private Singleton() { }

    /// <summary>
    /// Gets the singleton instance in a thread-safe manner.
    /// </summary>
    public static Singleton Instance
    {
        get
        {
            // Ensure thread safety
            lock (_lock)
            {
                // Create the instance if it doesn't exist
                return _instance ??= new Singleton();
            }
        }
    }

    /// <summary>
    /// Example method to demonstrate Singleton functionality.
    /// </summary>
    public void DoSomething()
    {
        Console.WriteLine("Singleton is working");
    }
}