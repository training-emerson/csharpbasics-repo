
using System;
using System.IO;

class Program()
{

    static void Main(string[] sumNavg)
    {

        if (sumNavg.Length > 0)
        {
            numbersum(sumNavg);
            Console.WriteLine("End of Main");
        }
        else
            Console.WriteLine("Enter Parameters");
    }
    static void numbersum(string[] args)
    {
        int initSum = 0;
        int length = args.Length;
        int avg = 0;
        for (int index = 0; index < length; index++)
        {
            initSum = initSum + int.Parse(args[index]);

        }
        Console.WriteLine("Sum:" + initSum);
        avg = initSum / length;
        Console.WriteLine("avg:" + avg);
    }

}