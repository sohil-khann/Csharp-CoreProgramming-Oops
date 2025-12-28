using System;

/*
Sample Program 1: Bank Account System
Create a BankAccount class with the following features:
 static:
     A static variable bankName shared across all accounts.
     A static method GetTotalAccounts() to display the total number of accounts.
 this:
     Use this to resolve ambiguity in the constructor when initializing AccountHolderName and AccountNumber.
 readonly:
     Use a readonly variable AccountNumber to ensure it cannot be changed once assigned.
 is operator:
     Check if an account object is an instance of the BankAccount class before displaying its details.
*/

namespace Level_01
{
    public class BankAccount
    {
        public static string bankName = "Global Trust Bank";
        private static int totalAccounts = 0;

        public string AccountHolderName;
        public readonly string AccountNumber;

        public BankAccount(string AccountHolderName, string AccountNumber)
        {
            this.AccountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;
            totalAccounts++;
        }

        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }

        public void ShowDetails()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine($"Bank Name: {bankName}");
            Console.WriteLine($"Account Holder: {this.AccountHolderName}");
            Console.WriteLine($"Account Number: {this.AccountNumber}");
        }
    }

    public class BankAccountSystem
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to the Bank Account System");
            
            Console.Write("Enter Account Holder Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();

            object accountObj = new BankAccount(name, accNo);

            // Using 'is' operator to verify the object type
            if (accountObj is BankAccount myAccount)
            {
                myAccount.ShowDetails();
            }
            else
            {
                Console.WriteLine("Error: The object is not a valid BankAccount instance.");
            }

            Console.WriteLine($"Total Accounts registered in {BankAccount.bankName}: {BankAccount.GetTotalAccounts()}");
        }
    }
}
