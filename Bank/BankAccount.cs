using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        double balance;
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance
        {
            get
            {
                return balance;
            }
        }
        public BankAccount(int accountNumber, string customerName, double initialBalance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            balance = initialBalance;
        }
        public void Withdraw(double amount)
        {
            if (balance < amount)
            {
                throw new ArgumentOutOfRangeException("Amount cannot be greator than the Balance!");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount cannot be 0 or Negative!!");
            }
            else
            {
                balance -= amount;
            }
        }
        public void Deposit(double amount)
        {

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount cannot be 0 or Negative!!");
            }

            else { balance += amount; }
        }

    }
}
