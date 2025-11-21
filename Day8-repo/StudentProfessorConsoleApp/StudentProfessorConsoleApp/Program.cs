using StudentProfessorConsoleApp.Domain;
using System;

namespace StudentProfessorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prof1 = new Professor("P1001", "Krishna", "Krishna.kant@live.com", new DateTime(1984, 8, 22), 50000, 50);
            var prof2 = new Professor("P1002", "Bala", "Balat@live.com", new DateTime(1980, 10, 20), 60000, 50);
            var student1 = new Student("S1001", "Amit", "Amit@live.com", new DateTime(2001, 1, 1), "Electrical");
            var student2 = new Student("S1002", "Sumit", "Sumit@live.com", new DateTime(2001, 5, 5), "Mechanical");
            
            PrintInfo(prof1);
            PrintInfo(prof2);
            PrintInfo(student1);
            PrintInfo(student2);

        }

        private static void PrintInfo(Professor prof)
        {
            Console.WriteLine($"Professor with id: {prof.Id} having name: {prof.Name}, emailid: {prof.EmailId} and DOB: {prof.Dob} has salary as {prof.CalculateSalary()} ");
        }
        private static void PrintInfo(Student student)
        {
            Console.WriteLine($"Student with id: {student.Id} having name: {student.Name}, emailid: {student.EmailId} and DOB: {student.Dob} is student of {student.Branch} Branch ");

        }
    }
}
