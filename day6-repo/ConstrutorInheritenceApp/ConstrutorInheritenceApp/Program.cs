using ConstrutorInheritenceApp.Domain.CaseStudy1;
using ConstrutorInheritenceApp.Domain.CaseStudy2;
using System;

namespace ConstrutorInheritenceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ChildOne();
            ChildTwo child1 = new ChildTwo();
            Console.WriteLine(child1.Age);
            new ChildOne();
            ChildTwo child2 = new ChildTwo();
            Console.WriteLine(child2.Age);
            new ChildOne();
            ChildTwo child3 = new ChildTwo(40);
            Console.WriteLine(child3.Age);

        }
    }
}
