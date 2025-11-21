using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Domain
{
    class Developer : Employee
    {
        private double _hra;
        private double _pa;
        public Developer(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            _hra = .40 * _basicSalary;
            _pa = .30 * _basicSalary;

        }

        public override double CalculateTotalSalary()
        {
            return _basicSalary+_hra+_pa;
        }

        public override string Role
        {
            get
            {
                return "Developer";
            }
        }
    }
}
