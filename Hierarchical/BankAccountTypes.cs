using System;

namespace HierarchicalInheritance
{
    // Base class BankAccount
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: ${Balance}");
        }
    }

    // Subclass SavingsAccount
    public class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountNumber, decimal balance, double interestRate) 
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Savings Account");
            DisplayDetails();
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }

    // Subclass CheckingAccount
    public class CheckingAccount : BankAccount
    {
        public decimal WithdrawalLimit { get; set; }

        public CheckingAccount(string accountNumber, decimal balance, decimal withdrawalLimit) 
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Checking Account");
            DisplayDetails();
            Console.WriteLine($"Withdrawal Limit: ${WithdrawalLimit}");
        }
    }

    // Subclass FixedDepositAccount
    public class FixedDepositAccount : BankAccount
    {
        public int TermMonths { get; set; }

        public FixedDepositAccount(string accountNumber, decimal balance, int termMonths) 
            : base(accountNumber, balance)
        {
            TermMonths = termMonths;
        }

        public void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Fixed Deposit Account");
            DisplayDetails();
            Console.WriteLine($"Term: {TermMonths} months");
        }
    }
}
