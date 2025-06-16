namespace DesignPatterns.Structural.Adadpter.Legacy;

public class OldLogger
{
    public void WriteLog(string msg)
    {
        Console.WriteLine("Old Logger: " + msg);
    }
}