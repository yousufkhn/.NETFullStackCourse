using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToTest
{
    public class Program1
    {
        public decimal Balance { get; set; }
        static void Main(string[] args)
        {

        }

        public Program1(decimal balance)
        {
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Deposit amount cannot be negative");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new Exception("Insufficient funds");
            }
            Balance -= amount;
        }
    }
}
