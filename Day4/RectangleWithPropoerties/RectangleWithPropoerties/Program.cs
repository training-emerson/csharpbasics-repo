using RectangleWithPropoerties.Domain;
using System;

namespace RectangleWithPropoerties
{
   class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Color = "pink";
            rect1.Height = 10;
            rect1.Width = 10;
            Console.WriteLine("Color of rectangle is " + rect1.Color);
            Console.WriteLine("area of rectangle is " + rect1.CalculateArea());
        }
    }
}
