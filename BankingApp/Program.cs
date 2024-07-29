using System;

namespace BankingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1,123456, "Sachin", "SBI",100 );
            Account account2 = new Account(2,678901, "Rahul", "HDFC", 800);

            Account[] accounts = new Account[] { account1, account2 };

            Console.WriteLine("Enter the account ID you want to access:");
            int accountId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Adhaar number:");
            int adharId = int.Parse(Console.ReadLine());

            Account selectedAccount = Account.GetAccountById(accounts, accountId);

            if (selectedAccount != null && adharId != 0)
            {
                try
                {
                    Console.WriteLine("Do you want to deposit or withdraw money? (Enter 'd' for deposit and 'w' for withdraw):");
                    char choice = char.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 'd':
                            Console.WriteLine("Enter the amount you want to deposit:");
                            double depositAmount = double.Parse(Console.ReadLine());
                            double newBalanceAfterDeposit = selectedAccount.Deposit(depositAmount);
                            Console.WriteLine("Bank balance is Rs " + newBalanceAfterDeposit);
                            break;
                        case 'w':
                            Console.WriteLine("Enter the amount you want to withdraw:");
                            double withdrawalAmount = double.Parse(Console.ReadLine());
                            double newBalanceAfterWithdrawal = selectedAccount.Withdrawal(withdrawalAmount);
                            Console.WriteLine("Balance left is Rs " + newBalanceAfterWithdrawal);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter 'd' to deposit or 'w' to withdraw.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Account with ID " + accountId + " not found.");
            }
        }






    }


}

