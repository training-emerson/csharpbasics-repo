using RectangleEncapulation.Domain;
using System;

class Program
{
    static void Main()
    {
        Rectangle rect1 = new Rectangle();
        rect1.SetColor("Pink");
        rect1.SetHeight(-1);
        rect1.SetWidth(200);
        PrintInfo(rect1);
    }

    static void PrintInfo(Rectangle rect)
    {
        Console.WriteLine("color is " + rect.GetColor());
        Console.WriteLine("height is " + rect.GetHeight());
        Console.WriteLine("width is " + rect.GetWidth());
        Console.WriteLine("area is " + rect.CalculateArea());
    }
}