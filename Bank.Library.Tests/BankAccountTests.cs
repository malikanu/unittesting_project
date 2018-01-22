using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Library.Tests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Credit_ValidAmount_UpdateBalance()
        {
            // To create a test methoid follow -> AAA's Pattern

            //Arrange
            double currentBalance = 11.99;
            double creditAmount = 4.55;
            double expected = 16.54;
            BankAccount account = new BankAccount("Mr. Bryan Adams", currentBalance);

            //Act
            account.Credit(creditAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
           

        }

        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {

            //Arrange
            double currentBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Adams", currentBalance);

            //Act
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");

        }

        // To Test: The method throws an ArgumentOutOfRangeException if the debit amount is less than zero.
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            double currentBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Adams", currentBalance);

            //Act
            account.Debit(debitAmount);

            //Assert is handled by ExpectedException
        }

        // To Test: The method throws an ArgumentOutOfRangeException if the debit amount exceeds the balance.
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            double currentBalance = 11.99;
            double debitAmount = 100.00;
            BankAccount account = new BankAccount("Mr. Bryan Adams", currentBalance);

            //Act
            account.Debit(debitAmount);

            //Assert is handled by ExpectedException
        }

    }
}
