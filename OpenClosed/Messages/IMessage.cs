using OpenClosed.Loggers;

namespace OpenClosed.Messages;

public interface IMessage
{
    public int Id { get; set; }
    public string content { get; set; }
}
