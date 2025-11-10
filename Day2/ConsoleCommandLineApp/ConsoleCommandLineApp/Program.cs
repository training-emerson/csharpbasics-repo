
using System;

class Program()
{
    static void Main(string[] parameters)
    {
        foreach (string para in parameters)
        {
            Console.WriteLine(para);
        }
        if (parameters.Length == 2)
        {
            string userName=parameters[0];
            int nTimes=int.Parse(parameters[1]);
            PrintNameNTimes(userName, nTimes);
        }
        Console.WriteLine("End of life");
    }

    static void PrintNameNTimes(string name, int times)
    {
        for (int counter = 1; counter <= times; counter++)
            Console.WriteLine(name.ToUpper());
    }
}