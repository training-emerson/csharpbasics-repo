using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass.Domain
{
    public class Transaction(string Type, double amount, DateTime date)
    {
     
        private string _Type = Type;
        private double _amount = amount;
        //private double _amountTrans;
        private DateTime _date = date;

        public double Amount { get { return _amount; } }
  
        public string Type { get { return _Type; } }

        public DateTime Date { get { return _date; } }

        //public double CalculateBalance(double trans)
        //{
        //    return _amount = _amount + trans;
        //}


    }
}
