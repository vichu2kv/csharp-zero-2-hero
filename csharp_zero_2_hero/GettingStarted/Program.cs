// See https://aka.ms/new-console-template for more information
using GettingStarted.Programs;
using System.ComponentModel.DataAnnotations;

namespace GettingStarted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Getting Started ===");
            Console.WriteLine("1. HelloWorld!");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    HelloWorld.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}