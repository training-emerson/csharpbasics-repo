

using System;

class Program
{

    static void Main()
    {

        Console.WriteLine("Welcome to array program");
        //CaseStudy1();
        //CaseStudy2();
        //CaseStudy3();
        CaseStudy4();

    }
    static void CaseStudy4()
    {
        string[] userNames = ["Gaurav", "Krishna, KK", "Ashish", "Hemang"];
        foreach (string temp in userNames)
        {
            Console.WriteLine(temp);
        }
    }
    static void CaseStudy3()
    {

        int[] ages = [10, 20, 30, 40, 50, 60];
        Console.WriteLine(ages.Length);
        for (int myIndex = 0; myIndex < ages.Length; myIndex++)
        {
            ages[myIndex] = ages[myIndex] * ages[myIndex];
            Console.WriteLine("Sachin's age is " + ages[myIndex]);
        }
        Console.WriteLine(ages.Length);
        for (int myIndex = 0; myIndex < ages.Length; myIndex++)
        {

            Console.WriteLine("Sachin's age is " + ages[myIndex]);
        }
    }

    static void CaseStudy2()
    {

        int[] ages = [10, 20, 30, 40, 50, 60];
        Console.WriteLine("legth of array is " + ages.Length);
        Console.WriteLine(ages[0]);
        Console.WriteLine(ages[2]);
        Console.WriteLine(ages[3]);
        Console.WriteLine(ages[4]);
        Console.WriteLine(ages[5]);

    }
    static void CaseStudy1()
    {


        int age = 35;
        string name = "Sachin";
        Console.WriteLine("Player name is " + name);
        Console.WriteLine("Player age is " + age);
        Console.WriteLine("Player name is " + name + " and Player age is " + age);
        Console.WriteLine($"{age}, {name}");


    }
}