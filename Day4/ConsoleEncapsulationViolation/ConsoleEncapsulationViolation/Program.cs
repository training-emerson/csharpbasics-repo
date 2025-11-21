using System;
using ConsoleEncapsulationViolation.Domain;

namespace ConsoleEncapsulationViolation //Program for calculating area of rectangle and using PrintInfo for printing information
{
    internal class Program
    {
        static void Main() // main method is creating an object
        {
            Rectangle big = new Rectangle();
            big.width = 1000;
            big.height = -10;
            big.color = "pink";
            string details = "big rectangle";

            PrintInfo(big,details);

            //DRY - dont repeat yourself

            Rectangle Small = new Rectangle();
            Small.width = 100;
            Small.height = 10;
            Small.color = "green";

            PrintInfo(Small);

            Rectangle notavalidrectangle = new Rectangle();
            notavalidrectangle.width = 0;
            notavalidrectangle.height = 0;
            notavalidrectangle.color = "xyw";

            PrintInfo(notavalidrectangle);

        }

        static void PrintInfo(Rectangle r) //it expects an object
        {

            Console.WriteLine("Print information of rectangle");
            Console.WriteLine("width is " + r.width);
            Console.WriteLine("height is " + r.height);
            Console.WriteLine("area is " + r.CalculateArea());
            Console.WriteLine("Color is " + r.color);
            Console.WriteLine("hash code is" + r.GetHashCode());
            Console.WriteLine();

        }
       
        static void PrintInfo(Rectangle r, string details)
        {
            Console.WriteLine("Rectangle name is: "+ details);
            PrintInfo(r);
            Console.WriteLine("Dev is KK");
        }
    }
}
