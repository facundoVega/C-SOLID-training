using DependencyInversion.Abstraction;

namespace DependencyInversion;

public class MailSender :ISender
{
    public void Send(string message)
    {
        Console.WriteLine($"SIMULATING MAIL SENDING WITH MESSAGE:  { message }");
    }
}
