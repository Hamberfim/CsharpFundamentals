/***************************************************************
* Name        : Banking, BankingAccount
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
*               Input:  list and describe
*               Output: list and describe        
***************************************************************/
using BankLibrary;
using System;
using System.Collections.Generic;


namespace BankingLibrary
{
    public class BankAccount
    {
        public string accountNumber { get; }
        public string ownerName { get; set; }
        public decimal balance { 
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    // balance = balance + item.Amount;
                    balance += item.Amount;
                }
                return balance;
            } 
        }

        // account number generator
        private static Guid Myuuid()
        {
            Guid g = Guid.NewGuid();
            return g;
        }

        private List<Transaction> allTransactions = new List<Transaction>();


        // contructor
        public BankAccount(string name, decimal initialBalance)
        {
            this.accountNumber = Guid.NewGuid().ToString();
            this.ownerName = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        // methods
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive value");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);

        }

        public void MakeWithDraw(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive value");
            }
            if (balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds to make this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine($"Date\t\tAmount\t\tBalance\t\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount:C}\t{balance:C}\t{item.Notes}");
            }

            return report.ToString();
        }

    }
}
