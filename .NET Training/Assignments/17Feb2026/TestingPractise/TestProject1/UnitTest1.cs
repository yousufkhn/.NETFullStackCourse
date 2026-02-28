using NUnit;
using NUnit.Framework;
using ClassToTest;

namespace TestProject1
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
        public void Test1()
        {
            decimal amount = 15000m;
            decimal finalAmount = 2000m;

            account.Deposit(amount);

            Assert.Throws<Exception>(()=>account.Deposit(-1500m));
        }
    }
}
