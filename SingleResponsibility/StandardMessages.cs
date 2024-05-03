
namespace SingleResponsibility;

public class StandardMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("*********Single Responsibility Pattern**************");
    }

    public static void EndApplication()
    {
        Console.ReadLine();
    }

    public static void DisplayValidationError(string fieldName)
    {
        Console.WriteLine($"You did not give us a valid { fieldName }!");
    }
}
