using NUnit.Framework;

namespace TestingDemo
{
    public class Program
    {
        public decimal Balance { get; set; }
        public static void Main(string[] args)
        { }

        public Program(decimal bal)
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

    [TestFixture]
    public class UnitTest
    {
        private Program account;
        [SetUp]
        public void Setup()
        {
            account = new Program(1000m);
        }

        [Test]
        public void Test_Deposit_ValidAmount()
        {
            decimal deposit = 1000m;
            decimal expectedTotal = 2000m;
            account.Deposit(1000m);

            Assert
            
        }
    }

}