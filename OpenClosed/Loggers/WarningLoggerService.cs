using OpenClosed.Messages;

namespace OpenClosed.Loggers
{
    public class WarningLoggerService : ILoggerService
    {
        public void Log(IMessage message)
        {
            Console.WriteLine($"LOG LEVEL: WARNING, ID: {message.Id}, CONTENT: {message.content}");
        }
    }
}
