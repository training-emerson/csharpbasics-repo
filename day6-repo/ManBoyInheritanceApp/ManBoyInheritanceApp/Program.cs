using ManBoyInheritanceApp.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace ManBoyInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy2();
            //CaseStudy1();
           // CaseStudy3();
            //CaseStudy4();
            CaseStudy5();

        }

        private static void CaseStudy5()
        {
            object x;
            x = 100;
            Console.WriteLine(x.GetType());

            x = "hello";
            Console.WriteLine(x.GetType());

            x = new Man();
            Console.WriteLine(x.GetType());

            Man temp = x as Man;
            Console.WriteLine(temp.GetType());
            temp.Read();

        }

        private static void AtThePark(Man x)
        {
            Console.WriteLine( "at the park..");
            x.Play();
        }
        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Infant());
            AtThePark(new Toddler());
            AtThePark(new NewBorn());

        }

        private static void CaseStudy3()
        {
            Man z;
            z = new Boy();
            z.Play();
            z.Read();
        }

        private static void CaseStudy2()
        {
            Boy y;
            y = new Boy();
            y.Play();
            y.Eat();
            y.Read();
        }

        private static void CaseStudy1()
        {
            Man x;
            x = new Man();
            x.Play();
            x.Read();
        }
    }
}
