using PointerApp.Domain;
using System;

namespace PointerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player virat = new Player("Virat", 38, 400);
            Player sachin = new Player("Sachin", 55, 450);
            Player elder = virat.WhoIsElder(sachin);
            Console.WriteLine(elder.Name);

        }
    }
}
