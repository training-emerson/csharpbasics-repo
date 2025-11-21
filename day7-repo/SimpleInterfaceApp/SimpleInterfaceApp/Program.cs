using SimpleInterfaceApp.DataAccess;
using System;

namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoDbOperations(new OrderDB());
            DoDbOperations(new CustomerDB());  
            DoDbOperations(new InvoiceDB());
        }

        //polymorphic method
        static void DoDbOperations(ICrudable obj)
        {
            Console.WriteLine(obj.GetType());
            Console.WriteLine("Doing db operations");
            obj.Update();
            obj.Create();
            obj.Read();
            obj.Delete();
            Console.WriteLine();
        }
    }
}
