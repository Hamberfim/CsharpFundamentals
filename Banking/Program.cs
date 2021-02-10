/***************************************************************
* Name        : Banking
* Author      : Anthony Hamlin
* Created     : 02/04/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : MS-Tutorial
* Description : Bank account behavior:
*                   It has a 10-digit number that uniquely identifies the bank account.
*                   It has a string that stores the name or names of the owners.
*                   The balance can be retrieved.
*                   It accepts deposits.
*                   It accepts withdrawals.
*                   The initial balance must be positive.
*                   Withdrawals cannot result in a negative balance.     
***************************************************************/
using System;
using System.Globalization;  // needed for title case
using System.Collections.Generic;  // needed fot list array
using BankingLibrary;  // moved to it's own dir/library

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            // list to hold generated accounts
            var accountsList = new List<string>
            {

            };

            // Creates a TextInfo based on the "en-US" culture for Title Case.
            TextInfo myTC = new CultureInfo("en-US", false).TextInfo;

            // initial account setup with deposit for Bill
            var account = new BankAccount("bill william", 10000);  
            accountsList.Add($"{account.accountNumber}, {myTC.ToTitleCase(account.ownerName)}, {account.balance:C}");
            //Console.WriteLine($"Account Name: {myTC.ToTitleCase(account.ownerName)}, Balance: {account.balance:C}");

            account.MakeWithDraw(100, DateTime.Now, "Night Out on the Town");  // withdraw
            accountsList.Add($"{account.accountNumber}, {myTC.ToTitleCase(account.ownerName)}, {account.balance:C}");
            //Console.WriteLine($"Account Name: {myTC.ToTitleCase(account.ownerName)}, Balance: {account.balance:C}");

            Console.WriteLine($"\t===== ACCOUNT HISTORY FOR {myTC.ToTitleCase(account.ownerName)} =====");
            Console.WriteLine(account.GetAccountHistory());  // get transaction history with date stamp and notes

            Console.WriteLine();
            // an account for richard
            account = new BankAccount("richard fletcher", 80000);
            accountsList.Add($"{account.accountNumber}, {myTC.ToTitleCase(account.ownerName)}, {account.balance:C}");

            account.MakeDeposit(1500, DateTime.Now, "Sold old sofa");  //deposit
            accountsList.Add($"{account.accountNumber}, {myTC.ToTitleCase(account.ownerName)}, {account.balance:C}");

            account.MakeWithDraw(600, DateTime.Now, "Flight to Chicago");  // withdraw
            accountsList.Add($"{account.accountNumber}, {myTC.ToTitleCase(account.ownerName)}, {account.balance:C}");

            Console.WriteLine($"\t===== ACCOUNT HISTORY FOR {myTC.ToTitleCase(account.ownerName)} =====");
            Console.WriteLine(account.GetAccountHistory());  // get transaction history with date stamp and notes

            Console.WriteLine();
            // an account for kristian
            account = new BankAccount("kristian Grommiski", 40000);
            accountsList.Add($"{account.accountNumber}, {myTC.ToTitleCase(account.ownerName)}, {account.balance:C}");

            account.MakeDeposit(9000, DateTime.Now, "Sold car");  //deposit
            accountsList.Add($"{account.accountNumber}, {myTC.ToTitleCase(account.ownerName)}, {account.balance:C}");

            account.MakeWithDraw(1200, DateTime.Now, "Wedding gift");  // withdraw
            accountsList.Add($"{account.accountNumber}, {myTC.ToTitleCase(account.ownerName)}, {account.balance:C}");

            account.MakeWithDraw(300, DateTime.Now, "Dinner party");  // withdraw
            accountsList.Add($"{account.accountNumber}, {myTC.ToTitleCase(account.ownerName)}, {account.balance:C}");

            Console.WriteLine($"\t===== ACCOUNT HISTORY FOR {myTC.ToTitleCase(account.ownerName)} =====");
            Console.WriteLine(account.GetAccountHistory());  // get transaction history with date stamp and notes

            Console.WriteLine();
            // ouput list of accounts
            Console.WriteLine("\t===== ALL ACCOUNT TRANSACTION BALANCES =====");
            foreach (var item in accountsList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
