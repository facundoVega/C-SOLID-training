using SingleResponsibility;
using System;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            //Ask for information
            var user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            } 

            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }

        //public static void MainWithoutSRPApproach()
        //{
        //    Console.WriteLine("*********Single Responsibility Pattern**************");

        //    //Ask for information
        //    Person user = new Person();

        //    Console.WriteLine("What is your first name  ");
        //    user.FirstName = Console.ReadLine();

        //    Console.WriteLine("What is your last name  ");
        //    user.LastName = Console.ReadLine();

        //    // Checks to be sure the first and last names are valid
        //    if (string.IsNullOrWhiteSpace(user.FirstName))
        //    {
        //        Console.WriteLine("You did not give us a valid first name!");
        //        Console.ReadLine();
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(user.LastName))
        //    {
        //        Console.WriteLine("You did not give us a valid last name!");
        //        Console.ReadLine();
        //        return;
        //    }

        //    //Create a username for the person
        //    Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");

        //    Console.ReadLine();
        //    StandardMessages.EndApplication();
        //}
    }
}