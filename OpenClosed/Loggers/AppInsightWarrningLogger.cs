using OpenClosed.Messages;

namespace OpenClosed.Loggers;

public class AppInsightWarrningLogger : ILoggerService
{
    public void Log(IMessage message)
    {
        Console.WriteLine("****************APP INSIGHT LOG**********************");
        Console.WriteLine($"LOG LEVEL: WARNING, ID: {message.Id}, CONTENT: {message.content}");
    }
}
