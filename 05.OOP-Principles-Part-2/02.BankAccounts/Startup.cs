namespace BankAccounts
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Models.BankModels;
    using Models.CustomerModels;

    class Startup
    {
        static void Main()
        {
            List<IAccount> accounts = new List<IAccount>()
            {
                new Loan(new CompanyCustomer("Coca-Cola"), 300000, 0.5m, 9),
                new Loan(new IndividualCustomer("Peter Jackson"), 3000, 0.9m, 11),
                new Loan(new CompanyCustomer("Pepsi"), 150000, 0.4m, 7),
                new Loan(new IndividualCustomer("Jonny Bravo"), 30000, 0.8m, 12),
                new Deposit(new IndividualCustomer("Strahil Popov"), 5000, 1.5m, 12),
                new Deposit(new CompanyCustomer("The Killers"), 500000, 1.1m, 18),
                new Deposit(new IndividualCustomer("Toshko Afrikansi"), 50000, 1.2m, 12),
                new Deposit(new CompanyCustomer("Terminator"), 15000, 0.5m, 12),
                new Mortgage(new CompanyCustomer("Ala-Bala Ltd"), 2000, 0.8m, 10),
                new Mortgage(new IndividualCustomer("Ali Baba"), 200, 0.8m, 10),
                new Mortgage(new CompanyCustomer("SLS"), 200000, 0.8m, 10),
                new Mortgage(new IndividualCustomer("Ali Reza"), 20000, 0.8m, 10)
            };

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n----------------------Test making deposit----------------------\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.GetType().Name}");
                Console.WriteLine($"Before Deposit: {account.Balance} $");
                account.MakeDeposit(100);
                Console.WriteLine($"After Deposit: {account.Balance} $");
                Console.WriteLine("-------------------------");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n----------------------Test calculating amount----------------------\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var account in accounts)
            {
                Console.Write($"Months: {account.NumberOfMonths} Interest Rate: {account.InterestRate}% ");
                Console.WriteLine($"Interest Amount: {account.CalculateAmount()}%\n");
                Console.WriteLine("-----------------------------------------------------");
            }

            Bank FFBank = new Bank("FFBank");
            FFBank.Accounts = accounts;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n----------------------Test Bank Class----------------------\n");
            
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var account in FFBank.Accounts)
            {
                Console.WriteLine($"Account Type: {account.GetType().Name},  Customer: {account.Customer.Name}");
                Console.WriteLine("---------------------------------------------------------");
            }

        }
    }
}
