using System;
using SimpleBankingSystem;

Bank bank = new Bank();
bool exit = false;

while (!exit)
{
    Console.WriteLine("n--- Simple Banking System ---");
    Console.WriteLine("1. Create Account");
    Console.WriteLine("2. Deposit Money");
    Console.WriteLine("3. Withdraw Money");
    Console.WriteLine("4. Check Balance");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            bank.CreateAccount();
            break;
        case "2":
            bank.DepositMoney();
            break;
        case "3":
            bank.WithdrawMoney();
            break;
        case "4":
            bank.CheckBalance();
            break;
        case "5":
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

namespace SimpleBankingSystem
{
    class Bank
    {
        private string accountHolderName;
        private decimal balance;

        public void CreateAccount()
        {
            Console.Write("Enter account holder name: ");
            accountHolderName = Console.ReadLine();
            balance = 0; // Initial balance is zero
            Console.WriteLine($"Account created successfully for {accountHolderName}.");
        }

        public void DepositMoney()
        {
            if (string.IsNullOrEmpty(accountHolderName))
            {
                Console.WriteLine("No account found. Please create an account first.");
                return;
            }

            Console.Write("Enter amount to deposit: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C}. New balance is {balance:C}.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
        }

        public void WithdrawMoney()
        {
            if (string.IsNullOrEmpty(accountHolderName))
            {
                Console.WriteLine("No account found. Please create an account first.");
                return;
            }

            Console.Write("Enter amount to withdraw: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Successfully withdrew {amount:C}. New balance is {balance:C}.");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
        }

        public void CheckBalance()
        {
            if (string.IsNullOrEmpty(accountHolderName))
            {
                Console.WriteLine("No account found. Please create an account first.");
                return;
            }

            Console.WriteLine($"Current balance for {accountHolderName}: {balance:C}");
        }
    }
}

