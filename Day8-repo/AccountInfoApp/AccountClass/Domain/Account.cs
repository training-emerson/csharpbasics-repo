using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass.Domain
{
    public class Account
    {
        private string _name;
        private string _id;
        private double _initialAmount;
        private List<Transaction> _newTransaction;

        public Account(string name, string id, double initialAmount)
        {
            //_iAmount = iAmount;
            _id = id;
            _name = name;
            _initialAmount = initialAmount;
            _newTransaction = new List<Transaction>();

            if (initialAmount > 0)
            {

                Deposit(initialAmount, DateTime.Now);
            }
        }

        public void Deposit(double amount1, DateTime date)
        {
            if (amount1 <= 0)
            {

                Console.WriteLine("Insufficient fund");
            }
            _newTransaction.Add(new Transaction("Deposit", amount1, date));
            Console.WriteLine($"Amount deposited in account is = {amount1}");
        }
        public void Withdraw(double amount1, DateTime date)
        {
            if (amount1 <= 0)
            {

                Console.WriteLine("Insufficient fund");
            }
            amount1 = -amount1;
            _newTransaction.Add(new Transaction("WithDraw", amount1, date));
            Console.WriteLine( $"Amount withdrawn from account is = {amount1}");
        }

        public double GetTotalAmount()
        {
            double total = 0;
            foreach (var temp in _newTransaction)
            {
                total += temp.Amount;
            }
            return total;
        }

        public List<Transaction> GetTransactions()
        {
            return _newTransaction;
        }
        public string Name { get { return _name; } }
        public string Id { get { return _id; } }

        public double InitialAmount { get { return _initialAmount; } }

    }
}
