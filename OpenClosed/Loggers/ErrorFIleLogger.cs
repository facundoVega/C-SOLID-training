using OpenClosed.Messages;

namespace OpenClosed.Loggers
{
    public class ErrorFileLogger : ILoggerService
    {
        public void Log(IMessage message)
        {
            Console.WriteLine("****************FILE LOG**********************");
            Console.WriteLine($"LOG LEVEL: Error, ID: {message.Id}, CONTENT: {message.content}");
        }
    }
}
