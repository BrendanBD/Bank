using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount User1 = new BankAccount(001, "Aderson", 1000);
            Console.WriteLine("Type an amount to withdraw:");
            int amount = int.Parse(Console.ReadLine());
            User1.Withdraw(amount);
            Console.WriteLine(User1.Balance);
        }
    }
}
