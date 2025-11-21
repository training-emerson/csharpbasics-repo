using System;
using ConsoleConstructorAndEnumApp.Domain;

namespace ConsoleConstructorAndEnumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(10,20,"yellow");
            PrintInfo(rectangle1);
        }

        static void PrintInfo(Rectangle rect)
        {
            Console.WriteLine($"Width is {rect.Width}");
            Console.WriteLine($"Height is {rect.Height}");
            Console.WriteLine($"Color is {rect.Color}");

        }
    }
}
