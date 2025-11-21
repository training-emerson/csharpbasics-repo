using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSalarySlipApp.Domain
{
    internal class Employee
    {
        private string _name;
        private double _basicpay;
        private int _hra;

        public Employee(string name, double basicpay, int hra)
        {
            _name = name;
            _basicpay = basicpay;
            _hra = hra;
        }

        public double HraIncome 
        {
            get 
            { 
                return _hra*_basicpay/100;
            } 
        }
        public string name
            { get { return _name; } }
        public double basicpay
            { get { return _basicpay; } }   
        
        

    }
}
