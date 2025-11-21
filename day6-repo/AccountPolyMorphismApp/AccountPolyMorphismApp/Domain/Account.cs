using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolyMorphismApp.Domain
{
    abstract class Account
    {

        private int _accnol;
        private string _name;
        protected double _balance;

        public Account(int accno, string name, double balance)

        {

            _accnol = accno;
            _name = name;
            _balance = balance;


        }

        public abstract void Withdraw(double amount);


        public void Deposit(double amount)
        {

            _balance += amount;
        }

        public double GetBalance() { return _balance; }
        public string Name { get { return _name; } }



    }


}
