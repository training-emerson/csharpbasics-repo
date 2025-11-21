using CustomerInheritenceApp.Domain;
using System;
using System.Data.Common;
using System.Runtime.Intrinsics.Arm;

namespace CustomerInheritenceApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Customer c1 = new Customer("C1002", "Hari", "Noi", "NCR");
            Customer c2 = new Customer("C1002", "Hari", "Noi", "NCR");
            Customer c3 = c1;
            Console.WriteLine(c1==c2); //reference based equality
            Console.WriteLine(c1==c3); 
            Console.WriteLine(c1.Equals(c2)); //Value based equality

        }
        static void CaseStudy2()
        {
            Customer c1 = new Customer("C1002", "Hari", "Noi", "NCR");
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c1.GetType());
        }
        static void CaseStudy1()
        {
            PrintInfo(new Customer("C2001", "Krishna"));
            PrintInfo(new Customer("C3001", "Krishna", "Lucknow"));
            PrintInfo(new Customer("C4001", "kk", "GreNo", "UP"));
        }
        static void PrintInfo(Customer customer)
        {
            Console.WriteLine("id " + customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Location);
            Console.WriteLine(customer.State);


        }
    }
}
