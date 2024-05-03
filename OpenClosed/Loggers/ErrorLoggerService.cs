using OpenClosed.Messages;

namespace OpenClosed.Loggers;

public class ErrorLoggerService : ILoggerService
{
    public void Log(IMessage message)
    {
        Console.WriteLine($"LOG LEVEL: ERROR, ID: {message.Id}, CONTENT: {message.content}");
    }
}
