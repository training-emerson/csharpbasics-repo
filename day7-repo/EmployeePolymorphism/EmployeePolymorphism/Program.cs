using EmployeePolymorphism.Domain;
using System;

namespace EmployeePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var developer = new Developer(1001, "KK", 2000);
            var manager = new Manager(1002, "Krishna", 3000);

            PrintSalarySlip(developer);
            PrintSalarySlip(manager);

        }

        static void PrintSalarySlip(Employee employee)
        {
            Console.WriteLine("id " + employee.Id);
            Console.WriteLine( "name "+ employee.Name);
            Console.WriteLine("role " + employee.Role);
            // display other components from Developer and manager salary structures
        }
    }
}
