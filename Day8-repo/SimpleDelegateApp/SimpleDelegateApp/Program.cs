using System;

namespace SimpleDelegateApp
{
    delegate void DPrintMessage(string name);
    delegate void DMathOperation(int num1, int num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //PrintWizard(PrintHello); //passed a function in delegate, it is callback (function taking another function is a callback)
            //PrintWizard(Shutdown);

            DMathOperation fnPtr = Add;
            fnPtr += Sub;
            fnPtr += Div;
            fnPtr += Mult;
            fnPtr += Modulus;

            fnPtr(20, 5);

        }
        private static void Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine($"{num1} + { num2} = { sum}");
        }
        private static void Sub(int num1, int num2)
        {
            int subt = num1 - num2;
            Console.WriteLine($"{ num1} - { num2} = { subt}");
        }
        private static void Div(int num1, int num2)
        {
            int div = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {div}");
        }
        private static void Mult(int num1, int num2)
        {
            int mult = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {mult}");
        }

        private static void Modulus(int num1, int num2)
        {
            int mod = num1 % num2;
            Console.WriteLine($"{num1} % {num2} = {mod}");
        }
        private static void Shutdown(string name)
        {
            Console.WriteLine($"Shutting down the system {name}");
        }

        static void PrintWizard(DPrintMessage fnPtrCallbck) //polymorphic
        {

            Console.WriteLine("Inside print wizard..");
            Console.WriteLine("doing some printing operation and notify once done");

            fnPtrCallbck("Work Done by printwizard");

        }
        private static void CaseStudy2()
        {
            DPrintMessage fnPointer; //null pointer
            fnPointer = PrintGoodBye; // object of delegate
            fnPointer += PrintHello;
            fnPointer += PrintGoodBye;


            fnPointer("champ");
        }

        private static void CaseStudy1()
        {
            DPrintMessage fnPointer; // expects a function with same signature
            fnPointer = PrintGoodBye; //address or name of function
            fnPointer("emerson");
            fnPointer("Krishna");

            fnPointer = PrintHello;
            fnPointer("KK");
        }

        static void PrintHello(string name)
        {
            Console.WriteLine($"Hello Says {name}");
        }

        static void PrintGoodBye(string name)
        {
            Console.WriteLine($"GoodBye says {name}");
        }

        static void Foo(int x)
        {
            Console.WriteLine($"Value is {x}");
        }

    }
}
