using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountGM;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Withdrawl_WithValidAmount_UpdatesBalance()
        {
            // Arrange
    double beginningBalance = 342.89;
    double debitAmount = 105.09;
    double expected = 237.8;
    BankAccount account = new BankAccount("Mr. Gianni Morgan", beginningBalance);

    // Act
    account.Debit(debitAmount);

    // Assert
    double actual = account.Balance;
    Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void Withdrawl_WhenAmountIsLessThanZero_ShouldThrowAOOR()
        {
            // Arrange
            double beginningBalance = 342.89;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Gianni Morgan", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
        [TestMethod]
        public void Withdrawl_WhenAmountIsMoreThanBalance_ShouldThrowAOOR()
        {
            // Arrange
            double beginningBalance = 342.89;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Gianni Morgan", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));

        }
        [TestMethod]

        public void Deposit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 342.89;
            double creditAmount = 94.11;
            double expected = 437.00;
            BankAccount account = new BankAccount("Mr. Gianni Morgan", beginningBalance);

            // Act
            account.Credit(creditAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
        }
        [TestMethod]

        public void Deposit_WhenAmountIsLessThanZero_ShouldThrowAOOR()
        {
            // Arrange
            double beginningBalance = 342.89;
            double creditAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Gianni Morgan", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Credit(creditAmount));
        }

    }
}
