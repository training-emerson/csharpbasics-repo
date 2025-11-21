using System;
using AccountClass.Domain;
using AccountInfoSlipAppClient;

namespace AccountInfoSlipAppClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new Account("1001", "Krishna", 1000);
            myAccount.Deposit(600, DateTime.Now);
            myAccount.Withdraw(1500, DateTime.Now);
            //myAccount.GetTotalAmount();
            Console.WriteLine($"Total balance in the account is: {myAccount.GetTotalAmount()}");
            Console.WriteLine($"Total Number of Transactions are:  {myAccount.GetTransactions().Count}");
        }
    }
}
