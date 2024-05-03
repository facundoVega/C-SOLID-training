using OpenClosed;
using OpenClosed.Loggers;
using OpenClosed.Messages;

namespace MyApp;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("************OCP**************************");

        List<IMessage> messages = new List<IMessage>
        {
            new Message { Id = 1, content = "Message 1" },
            new Message { Id = 2, content = "Message 2" },
            new Message { Id = 3, content = "Message 3" },
            new Message { Id = 4, content = "Message 4 "}
        };

        var logManager = new HandleLogService(new AppInsightWarrningLogger());

        var logErrorManager = new HandleLogService(new ErrorFileLogger());

        logErrorManager.Log(messages);
        logManager.Log(messages);


    }
}