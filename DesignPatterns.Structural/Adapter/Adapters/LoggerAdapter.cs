using DesignPatterns.Structural.Adadpter.Interfaces;
using DesignPatterns.Structural.Adadpter.Legacy;

namespace DesignPatterns.Structural.Adadpter.Adapters;

public class LoggerAdapter : INewLogger
{
    private readonly OldLogger _oldLogger = new();

    public void Log(string message)
    {
        _oldLogger.WriteLog(message);
    }
}