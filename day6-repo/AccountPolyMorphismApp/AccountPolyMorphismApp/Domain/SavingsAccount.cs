using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolyMorphismApp.Domain
{
    internal class SavingsAccount:Account
    {

        public SavingsAccount(int accno, string name, double balance):base (accno, name, balance)  
        {

        }

        public override void Withdraw(double amount)
        {
            _balance = _balance - amount;

        }
    }
}
