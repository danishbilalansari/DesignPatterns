using DesignPatterns.Structural.Adadpter.Interfaces;
using DesignPatterns.Structural.Adadpter.Legacy;

namespace DesignPatterns.Structural.Adadpter.Adapters;

/// <summary>
/// LoggerAdapter class. Adapts OldLogger to INewLogger interface.
/// </summary>
public class LoggerAdapter : INewLogger
{
    private readonly OldLogger _oldLogger = new();

    /// <summary>
    /// Logs a message using the adapted OldLogger.
    /// </summary>
    /// <param name="message">The message to log.</param>
    public void Log(string message)
    {
        _oldLogger.WriteLog(message);
    }
}