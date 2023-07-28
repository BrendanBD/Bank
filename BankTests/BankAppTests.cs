using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bank;
namespace BankTests
{
    [TestClass]
    public class BankAppTests
    {
        [TestMethod]
        [TestCategory("Basic Operations"), TestCategory("Important")]
        [Owner("Brendan")]
        public void Deposit_ValidAmount_UpdatesBalance()
        {
            //arrange
            int initialBalance = 1000;
            BankAccount test = new BankAccount(001, "Aderson", initialBalance);
            int depositAmount = 50;
            int expectedBalance = initialBalance + depositAmount;
            //act 
            test.Deposit(depositAmount);
            //assert
            Assert.AreEqual(expectedBalance, test.Balance);
        }
        [TestMethod]
        [TestCategory("Basic Operations"), TestCategory("Important")]
        [Owner("Brendan")]
        public void Withdraw_ValidAmount_UpdateBalance()
        {
            //arrange
            int amount = 50;
            int initialBalance = 1000;
            int expectedBalance = initialBalance - amount;
            BankAccount test2 = new BankAccount(002, "Aderson", initialBalance);
            //act
            test2.Withdraw(amount);
            //assert
            Assert.AreEqual(expectedBalance, test2.Balance);
        }
        [TestMethod]
        [TestCategory("Within Bounds Tests"), TestCategory("Very Important")]
        [Owner("Brendan")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OverDraw_Account()
        {
            //arrange
            int initialBalance = 1000;
            int withdrawAmount = 1001;
            BankAccount test3 = new BankAccount(003, "Aderson", initialBalance);
            //act
            test3.Withdraw(withdrawAmount);
            //assert

        }
        [TestMethod]
        [TestCategory("Within Bounds Tests"), TestCategory("Very Important")]
        [Owner("Brendan")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Withdraw_NonAbsolute_Amount()
        {
            //arrange
            int initialBalance = 100;
            int amount = -50;
            BankAccount test4 = new BankAccount(004, "Aderson", initialBalance);
            //act
            test4.Withdraw(amount);
            //assert
        }
        [TestMethod]
        [TestCategory("Within Bounds Tests"), TestCategory("Very Important")]
        [Owner("Brendan")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Deposit_NegativeAmount()
        {
            //arrange
            int initialBalance = 100;
            int amount = -50;
            BankAccount test5 = new BankAccount(005, "Aderson", initialBalance);
            //act
            test5.Deposit(amount);
            //assert
        }
    }
}