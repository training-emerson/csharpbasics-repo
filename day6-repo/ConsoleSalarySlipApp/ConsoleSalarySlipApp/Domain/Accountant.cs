using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSalarySlipApp.Domain
{
    internal class Accountant : Employee
    {
        public Accountant(string name, double basicpay, int hra) : base(name, basicpay, hra)
        {
        }
    }
}
