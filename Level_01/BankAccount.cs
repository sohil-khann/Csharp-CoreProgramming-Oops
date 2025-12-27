/*
 * LEVEL 2 PRACTICE - ACCESS MODIFIERS - PROBLEM 3: Bank Account Management
 * Create a BankAccount class with:
 * - accountNumber (public)
 * - accountHolder (protected)
 * - balance (private)
 * Implement methods to:
 * - Access and modify balance using public methods.
 * - Create a subclass SavingsAccount to demonstrate access to accountNumber and accountHolder.
 */

namespace PracticePrograms
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        protected string AccountHolder { get; set; }
        private decimal balance;

        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${balance}");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds");
                return false;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Holder: {AccountHolder}, Balance: ${balance}");
        }
    }

    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string accountNumber, string accountHolder, decimal initialBalance, decimal interestRate)
            : base(accountNumber, accountHolder, initialBalance)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            decimal interest = GetBalance() * InterestRate / 100;
            Deposit(interest);
            Console.WriteLine($"Interest of ${interest} applied");
        }

        public void DisplaySavingsInfo()
        {
            Console.WriteLine($"Account: {AccountNumber}, Holder: {AccountHolder}, Balance: ${GetBalance()}, Interest Rate: {InterestRate}%");
        }
    }
}
