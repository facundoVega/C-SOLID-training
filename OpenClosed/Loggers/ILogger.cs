using OpenClosed.Messages;

namespace OpenClosed.Loggers
{
    public interface ILoggerService
    {
        public void Log(IMessage message);
    }
}
