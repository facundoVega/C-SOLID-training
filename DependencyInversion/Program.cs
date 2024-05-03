using DependencyInversion;
using DependencyInversion.Abstraction;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******DEPENDENCY INVERSION************");

            var factory = new Factory();

            IPerson owner = factory.BuildPerson();

            owner.Name = "Jhon Doe";
            owner.Mail = "Jhon@Doe.com";
            owner.Age = 30;

            var chore = factory.BuildChore();
            chore.Duration = 10;
            chore.Owner = owner;
            chore.Title = "Fix UTs";


            chore.PerformTask(2);
            chore.PerformTask(4);

            chore.CompleteTask();

            Console.ReadLine();
        }
    }
}