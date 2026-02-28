using Microsoft.VisualStudio.TestPlatform.TestHost;
using TestingDemo;
using NUnit;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Tests
    {
        private Program1 account;
        [SetUp]
        public void Setup()
        {
            account = new Program1(1000m);
        }

        [Test]
        public void Test_Deposit_ValidAmount()
        {
            decimal amount = 1000m;
            decimal finalAmount = 2000m;
            account.Deposit(amount);

            Assert.That(finalAmount, Is.EqualTo(account.Balance));
        }
    }
}
