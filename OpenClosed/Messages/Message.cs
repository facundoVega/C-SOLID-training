using OpenClosed.Loggers;

namespace OpenClosed.Messages;

public class Message : IMessage
{
    public int Id { get; set; }
    public string content { get; set; }
}
