using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//PLEASE READ!!
/*Did not have time to add in transfers since I have to go to work. One way I would do it is shown below
 1. Create fields for checking and investment balance within bank account class
2. add additional parameters and create variables in public class
3. Create void method for transfer using checking and investment balance.
4. Setup Unit test
 */


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