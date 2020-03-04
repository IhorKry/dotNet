using System;

namespace dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Foo", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "new phone");
            account.MakeWithdrawal(100, DateTime.Now, "Xbox");

            System.Console.WriteLine(account.GetAccountHistory());




            // // Test for a negative balance.
            // try
            // {
            //     account.MakeWithdrawal(750000, DateTime.Now, "Attempt to overdraw");
            // }
            // catch (InvalidOperationException e)
            // {
            //     Console.WriteLine("Exception caught trying to overdraw");
            //     Console.WriteLine(e.ToString());
            // }

            // // Test that the initial balances must be positive.
            // try
            // {
            //     var invalidAccount = new BankAccount("invalid", -55);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exception caught creating account with negative balance");
            //     Console.WriteLine(e.ToString());
            // }
        }
    }
}
