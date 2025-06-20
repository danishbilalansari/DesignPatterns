namespace DesignPatterns.Structural.Adadpter.Interfaces;

/// <summary>
/// INewLogger interface. Represents the new logger interface.
/// </summary>
public interface INewLogger
{
    /// <summary>
    /// Logs a message.
    /// </summary>
    /// <param name="message">The message to log.</param>
    void Log(string message);
}