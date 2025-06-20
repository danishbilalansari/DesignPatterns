namespace DesignPatterns.Structural.Adadpter.Legacy;

/// <summary>
/// OldLogger class. Legacy logger implementation.
/// </summary>
public class OldLogger
{
    /// <summary>
    /// Writes a log message using the old logger.
    /// </summary>
    /// <param name="msg">The message to log.</param>
    public void WriteLog(string msg)
    {
        Console.WriteLine("Old Logger: " + msg);
    }
}