using System.Reflection;

namespace TestingDemo
{
    public class Program1
    {
        public decimal Balance { get; set; }
        public static void Main(string[] args)
        { }

        public Program1(decimal bal)
        {
            Balance = bal;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Deposit amount cannot be negative");
            }
            Balance+=amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new Exception("Insufficient funds");
            }
            Balance-=amount;
        }
    }
}