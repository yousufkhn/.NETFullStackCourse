using System;
using NUnit.Framework;
using SampleProject2;

namespace NUnitTestDemo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Deposit_ValidAmount()
        {
            Program account = new Program(100);

            account.Deposit(50);

            Assert.That(account.Balance, Is.EqualTo(150));
        }

        [Test]
        public void Test_Deposit_NegativeAmount()
        {
            // Arrange
            Program account = new Program(100);

            // Act & Assert (still ONE assert)
            Exception ex = Assert.Throws<Exception>(() => account.Deposit(-20));

            Assert.That("Deposit amount cannot be negative", Is.EqualTo(ex.Message));
        }

        [Test]
        public void Test_Withdraw_ValidAmount()
        {
            // Arrange
            Program account = new Program(200);

            // Act
            account.Withdraw(80);

            // Assert
            Assert.That(120, Is.EqualTo(account.Balance));
        }

        [Test]
        public void Test_Withdraw_InsufficientFunds()
        {
            // Arrange
            Program account = new Program(100);

            // Act & Assert
            Exception ex = Assert.Throws<Exception>(() => account.Withdraw(150));

            Assert.That("Insufficient funds.", Is.EqualTo(ex.Message));
        }

    }
}
