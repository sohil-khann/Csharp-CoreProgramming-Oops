using System;

/*
4. Banking System
Description: Create a banking system with different account types:
● Define an abstract class BankAccount with fields like accountNumber, holderName, and balance.
● Add methods like Deposit(double amount), Withdraw(double amount), and an abstract method CalculateInterest().
● Implement subclasses SavingsAccount and CurrentAccount with unique interest calculations.
● Create an interface ILoanable with methods ApplyForLoan() and CalculateLoanEligibility().
● Use encapsulation to secure account details and restrict unauthorized access.
● Demonstrate polymorphism by processing different account types and calculating interest dynamically.
*/

namespace Oops_Pillars
{
    // Interface for loan functionality
    public interface ILoanable
    {
        bool ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }

    // Abstract class for any bank account
    public abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        protected double balance;

        public string AccountNumber 
        { 
            get { return accountNumber; } 
        }
        
        public string HolderName 
        { 
            get { return holderName; } 
        }
        
        public double Balance 
        { 
            get { return balance; } 
        }

        public BankAccount(string accNo, string name, double initialBal)
        {
            accountNumber = accNo;
            holderName = name;
            balance = initialBal;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("Deposited: " + amount + ". New Balance: " + balance);
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawn: " + amount + ". Remaining Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Sorry, not enough balance or invalid amount.");
            }
        }

        // Every account type must calculate interest differently
        public abstract double CalculateInterest();

        public virtual void DisplayAccountDetails()
        {
            Console.WriteLine("Account No: " + accountNumber + ", Holder: " + holderName + ", Balance: " + balance);
        }
    }

    // Savings Account with interest and loan features
    public class SavingsAccount : BankAccount, ILoanable
    {
        private double interestRate = 0.04; // 4% interest

        public SavingsAccount(string accNo, string name, double initialBal)
            : base(accNo, name, initialBal) { }

        public override double CalculateInterest()
        {
            return balance * interestRate;
        }

        public bool ApplyForLoan(double amount)
        {
            double eligibility = CalculateLoanEligibility();
            if (amount <= eligibility)
            {
                Console.WriteLine("Loan of " + amount + " approved for Savings Account.");
                return true;
            }
            Console.WriteLine("Loan rejected. You are only eligible for " + eligibility);
            return false;
        }

        public double CalculateLoanEligibility()
        {
            return balance * 2; // Can take loan up to double the balance
        }

        public override void DisplayAccountDetails()
        {
            base.DisplayAccountDetails();
            Console.WriteLine("Account Type: Savings, Interest Earned: " + CalculateInterest());
        }
    }

    // Current Account with overdraft facility
    public class CurrentAccount : BankAccount
    {
        private double overdraftLimit = 5000;

        public CurrentAccount(string accNo, string name, double initialBal)
            : base(accNo, name, initialBal) { }

        public override void Withdraw(double amount)
        {
            if (amount > 0 && (balance + overdraftLimit) >= amount)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawn: " + amount + ". Current Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Transaction failed. Overdraft limit reached.");
            }
        }

        public override double CalculateInterest()
        {
            return 0; // No interest for current accounts
        }

        public override void DisplayAccountDetails()
        {
            base.DisplayAccountDetails();
            Console.WriteLine("Account Type: Current, Overdraft limit: " + overdraftLimit);
        }
    }
}
