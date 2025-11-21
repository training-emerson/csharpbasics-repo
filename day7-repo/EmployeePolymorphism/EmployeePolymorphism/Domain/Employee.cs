using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Domain
{
    abstract class Employee
    {
        private int _id;
        private string _name;
        protected double _basicSalary;

        public Employee(int id, string name, double basicSalary)
        {
            _id = id;
            _name = name;
            _basicSalary = basicSalary;
        }

        public abstract double CalculateTotalSalary();

        public abstract string Role
        {
            get;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }

        public double BasicSalary { get { return _basicSalary; } }
    }
}
