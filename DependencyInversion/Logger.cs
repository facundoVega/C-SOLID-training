using DependencyInversion.Abstractions;

namespace DependencyInversion;

public class Logger :ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"-INFO LOG:-:  { message }");
    }
}
