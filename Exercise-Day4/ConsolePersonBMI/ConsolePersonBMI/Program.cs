using ConsolePersonBMI.Domain;
using System.Drawing;

namespace ConsolePersonBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.Name = "pinki";
            person1.Height = 180;
            person1.Weight = 80;
            Console.WriteLine("Name of first person is " + person1.Name);
            Console.WriteLine($"BMI of {person1.Name} is " + person1.BMI());
            Console.WriteLine($"After Exercise, {person1.Name}'s weight is " + person1.Exercise());
            Console.WriteLine($"Weight after eating, {person1.Name}'s weight is " + person1.Eat());

        }
    }
}
