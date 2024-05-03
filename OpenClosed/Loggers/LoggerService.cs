using OpenClosed.Messages;

namespace OpenClosed.Loggers;

public class LoggerService : ILoggerService
{
    public void Log(IMessage message)
    {
        Console.WriteLine($"LOG LEVEL: INFO, ID: {message.Id}, CONTENT: {message.content}");
    }

}
