using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit(double depositAmount)
        {
            Console.WriteLine($"Thank you for making a deposit of {depositAmount, 0:c}.");
            balance = depositAmount;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
