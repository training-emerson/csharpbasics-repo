using System;
using System.Linq;
using ConsoleManyRectangles.Domain;

namespace ConsoleManyRectangles
{
    internal class Program
    {
        static void Main()
        {

            Rectangle[] manyrectangles = new Rectangle[3];
            Console.WriteLine(manyrectangles);

            manyrectangles[0] = new Rectangle();
            manyrectangles[0].width = 101;
            manyrectangles[0].height = 100;
            manyrectangles[0].color = "red";

            manyrectangles[1] = new Rectangle();
            manyrectangles[1].width = 10;
            manyrectangles[1].height = 10;
            manyrectangles[1].color = "blue";

            manyrectangles[2] = new Rectangle();
            manyrectangles[2].width = 5;
            manyrectangles[2].height = 5;
            manyrectangles[2].color = "green";

            PrintInfo(manyrectangles);
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
            Console.WriteLine("Rectangle name is: " + details);
            PrintInfo(r);
            Console.WriteLine("Dev is KK");
        }
        static void PrintInfo(Rectangle[] rectangles)
        {
            foreach (Rectangle rect in rectangles)
            {
                PrintInfo(rect);
            }
        }

    }
}
