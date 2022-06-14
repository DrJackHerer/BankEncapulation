using System;

namespace BankEncapulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            Console.WriteLine($"Showing balance {bankAccount.GetBalance()}");
        }
    }
}
