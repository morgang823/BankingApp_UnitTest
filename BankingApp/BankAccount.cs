using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountGM
{
    /// Bank Accoun Class
    public class BankAccount
    {
        private readonly string BAcustomerName;
        private double BAbalance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            BAcustomerName = customerName;
            BAbalance = balance;
        }

        public string CustomerName
        {
            get { return BAcustomerName; }
        }

        public double Balance
        {
            get { return BAbalance; }
        }

        public void Debit(double amount)
        {
            if (amount > BAbalance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            BAbalance -= amount; //debits the amount from balance
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount > 500)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            BAbalance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Gianni Morgan", 342.89);

            ba.Credit(94.11);
            ba.Debit(105.09);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}