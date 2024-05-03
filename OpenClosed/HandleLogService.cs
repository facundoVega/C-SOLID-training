using OpenClosed.Loggers;
using OpenClosed.Messages;

namespace OpenClosed;

public class HandleLogService
{
	private readonly ILoggerService _logger;
	public HandleLogService(ILoggerService log)
	{
		_logger = log;
	}

	public void Log(List<IMessage> messages)
	{
        foreach (var message in messages)
        {
            _logger.Log(message);
        }
    }
}
