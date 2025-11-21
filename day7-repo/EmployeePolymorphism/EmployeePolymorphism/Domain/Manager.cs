using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Domain
{
    class Manager : Employee
    {

        private double _hra;
        private double _ta;
        public Manager(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
           _hra = .50 * _basicSalary;
           _ta = .40 * _basicSalary;
            
        }
        public override double CalculateTotalSalary()
            {
            return _basicSalary + _hra + _ta;
        }

        public override string Role
        {
            get
            {
                return "Manager";
            }
        }
     
    }
}
