using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var theAccount = new BankAccount();
            Console.WriteLine("Welcome to our bank. How much would you like to deposit today?");
            double personsDeposit = double.Parse(Console.ReadLine());

            theAccount.Deposit(personsDeposit);         
            double personsBalance = theAccount.GetBalance();
            Console.WriteLine($"Your current balance is {personsBalance, 0:c}.");
            Console.WriteLine("Thank you for using our bank today!");
            Console.ReadLine();
            
           
        }
    }
}
