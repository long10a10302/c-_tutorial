using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise12_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter account name: ");
                string name = Console.ReadLine();
                Console.Write("Enter initial balance: ");
                float balance = float.Parse(Console.ReadLine());
                bankAccounts.Add(new BankAccount(name, balance));
            }

            Console.WriteLine("\nDisplaying all Bank Accounts:");
            foreach (var account in bankAccounts)
            {
                account.Display();
                account.Display(DateTime.Now);
            }

            List<Savings> savingsAccounts = new List<Savings>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter savings account name: ");
                string name = Console.ReadLine();
                Console.Write("Enter initial balance: ");
                float balance = float.Parse(Console.ReadLine());
                Console.Write("Enter interest rate: ");
                float interestRate = float.Parse(Console.ReadLine());
                savingsAccounts.Add(new Savings(name, balance, interestRate));
            }

            Console.WriteLine("\nDisplaying all Savings Accounts:");
            foreach (var savings in savingsAccounts)
            {
                savings.Display();
            }

            Console.Write("Enter number of months for interest calculation: ");
            int months = int.Parse(Console.ReadLine());
            foreach (var savings in savingsAccounts)
            {
                savings.CalculateInterest(months);
            }

        }
    }
}
