using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    internal class Account
    {

        private double _accountNumber;
        private string _accountName;
        private string _accountBankName;
        public const int MIN_BALANCE = 500;
        private double _accountBalance;
        private double _adhaarNumber;



        public Account(int accountNumber, string accountName, string accountBankName)
        {
            _accountNumber = accountNumber;
            _accountName = accountName;
            _accountBankName = accountBankName;
            _accountBalance = MIN_BALANCE;
        }

        public Account(int accountNumber, string accountName, string accountBankName, double accountBalance) : this(accountNumber, accountName, accountBankName)
        {
            _accountBalance = CheckBalance(accountBalance);
        }

        public Account(int accountNumber, double adhaarNumber, string accountName, string accountBankName) : this(accountNumber, accountName, accountBankName)
        {

        }
        public Account(int accountNumber, double adhaarNumber, string accountName, string accountBankName, double accountBalance)
        {
            _accountNumber = accountNumber;
            _accountName = accountName;
            _accountBankName = accountBankName;
            _accountBalance = accountBalance;
            _adhaarNumber = adhaarNumber;




        }

        public double Deposit(double amount)
        {

            _accountBalance += amount;
            return _accountBalance;

        }

        public double CheckBalance(double input)
        {
            if (input < MIN_BALANCE)
            {
                input = MIN_BALANCE;
            }
            return input;
        }
        public double Withdrawal(double amount)
        {
            if (Account.MIN_BALANCE > amount)
            {
                _accountBalance -= amount;
                return _accountBalance;
            }
            else
            {
                Console.WriteLine("Invalid");
                return _accountBalance;

            }


        }

        public static Account GetAccountById(Account[] accounts, int accountId)
        {
            foreach (Account account in accounts)
            {
                if (account._accountNumber == accountId)
                {
                    return account;
                }
            }
            return null;
        }

        public Account HighestBalance(Account[] accounts)
        {
            double highestBalance = 0;
            Account highestAccount=null;

            foreach (Account account in accounts)
            {
                if (account._accountNumber > highestBalance)
                {
                    highestBalance = account._accountNumber;
                    highestAccount = account;
                }


            }
            return highestAccount;

        }


        }





    }


