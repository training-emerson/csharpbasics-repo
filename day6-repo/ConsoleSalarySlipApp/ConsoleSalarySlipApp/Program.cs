using ConsoleSalarySlipApp.Domain;
using System;


namespace ConsoleSalarySlipApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee Ramesh = new Employee("Ramesh", 5000, 50 );
            Manager Krishna = new Manager("Krishna", 5000, 50);
            Dev Ankur = new Dev("Ankur", 5000, 40);
            Accountant Dinesh = new Accountant("Dinesh", 5000, 30);

            //PrintSalarySlip(Ramesh);
            PrintSalarySlip(Krishna);
            PrintSalarySlip(Ankur);
            PrintSalarySlip(Dinesh);

        }

        private static void PrintSalarySlip(Employee emp)
        {
            Console.WriteLine("Employee name is " + emp.name);
            Console.WriteLine($"{emp.name} basic income is " + emp.basicpay);
            Console.WriteLine($"{emp.name}Balance is " + emp.HraIncome);
            
        }
    }
}
