using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise12_02_02
{
    internal class Savings : BankAccount
    {

        public float InterestRate { get; private set; }

        public Savings(string accountName, float balance, float interestRate) : base(accountName, balance)
        {
            InterestRate = interestRate;
        }

        public void CalculateInterest(int months)
        {
            float newBalance = Balance;
            for (int i = 0; i < months; i++)
            {
                newBalance = (newBalance * InterestRate) / 100 + newBalance;
            }
            Console.WriteLine($"Balance after {months} months: {newBalance}");
        }

    }

}
