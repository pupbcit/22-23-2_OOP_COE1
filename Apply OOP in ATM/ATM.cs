using System;
using System.Collections.Generic;
using System.Reflection;

namespace IntroToCSharp
{
    internal class ATM
    {
        public int Cash { get; private set; }
        public Bank bank;

        internal static string Name = "Pavilion ATM";


        //ano yung mga actions na kaya nyang gawin

        public ATM() //same name ng class
        {
            Cash = 100000;
            List<Account> dummyaccounts = new List<Account>();
            bank = new Bank();

            Account account1 = new Account
            {
                PIN = "1234",
                accountNumber = "111-1234",
                amount = 700
            };

            Account account2 = new Account
            {
                PIN = "1234",
                accountNumber = "111-1235",
                amount = 500
            };

            Account account3 = new Account
            {
                PIN = "1234",
                accountNumber = "111-1236",
                amount = 200
            };


            Account account4 = new Account
            {
                PIN = "1234",
                accountNumber = "111-1237",
                amount = 500
            };

            Account account5 = new Account
            {
                PIN = "1234",
                accountNumber = "111-1238",
                amount = 300
            };

            dummyaccounts.Add(account1);
            dummyaccounts.Add(account2);
            dummyaccounts.Add(account3);
            dummyaccounts.Add(account4);
            dummyaccounts.Add(account5);

            bank.accounts = dummyaccounts;
        }

        public Account CheckPin(string pin, string accountNumber)
        {
            foreach (var account in bank.accounts)
            {
                if (account.PIN == pin && account.accountNumber == accountNumber)
                {
                    return account;
                }
            }

            return null;   
        }



        public void ChangePin(string accountNumber, string newPin, string oldPin)
        {

        }

        public bool Withdraw(Account account, int amountToWithdraw)
        {
            bool result = false;

            if (account.amount >= amountToWithdraw)
            {
                account.amount = account.amount - amountToWithdraw;
                result = true;
            }

            return result;
        }

        public void Deposit(string accountNumber, int amount)
        {

        }

        public void CheckBalance(string accountNumber)
        {

        }

        public void PrintReceipt(DateTime transactionDateTime, int transactionNumber, int amount)
        {

        }
    }
}