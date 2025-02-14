using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise12_02_02
{
    internal class BankAccount
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public float Balance { get; private set; }
        public int DepositeTimes { get; private set; }
        public int WithDrawTimes { get; private set; }
        private static int Count = 0;

        public BankAccount()
        {
            Count++;
            ID = Count;
            Name = "Initiator";
            Balance = 0;
        }

        public BankAccount(string AccountName, float balance)
        {
            Count++;
            ID = Count;
            Name = AccountName;
            Balance = balance;
        }

        public void Deposite(float amount)
        {
            Balance += amount;
            DepositeTimes++;
        }

        public void WithDraw(float amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                Balance -= amount;
                WithDrawTimes++;
            }
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Balance: {Balance}");
        }

        public void Display(DateTime currentDateTime)
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Balance: {Balance}, Deposits: {DepositeTimes}, Withdrawals: {WithDrawTimes}, Date: {currentDateTime}");
        }

    }
}
