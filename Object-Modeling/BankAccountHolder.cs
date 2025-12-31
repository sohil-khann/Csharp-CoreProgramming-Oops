/*Problem 2: Bank and Account Holders (Association)
Description: Model a relationship where a Bank has Customer objects associated with it. A
Customer can have multiple bank accounts, and each account is linked to a Bank.
Tasks:
 Define a Bank class and a Customer class.
 Use an association relationship to show that each Customer has an account in a
Bank.
 Implement methods that enable communication, such as OpenAccount() in the Bank
class and ViewBalance() in the Customer class.
*/


using System;
// Define the BankAccountHolder class
internal class BankAccountHolder
{
    // Properties
    public string Name { get; private set; }
    public decimal Balance { get; private set; }
    private Bank bank;
    // Constructor
    public BankAccountHolder(string name, Bank bank)
    {
        Name = name;
        Balance = 0;
        this.bank = bank;
    }

    // create Deposit method
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"{Name} deposited {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }// Withdraw method
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"{Name} withdrew {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
        }
    }
    public void ViewBalance()
    {
        Console.WriteLine($"{Name}'s balance at {bank.Name}: {Balance:C}");
    }
}// Define the Bank class
internal class Bank
{
    public string Name { get; private set; }
    public Bank(string name)
    {
        Name = name;
    }// Method to open an account for a customer
    public void OpenAccount(BankAccountHolder accountHolder)
    {
        Console.WriteLine($"Account opened for {accountHolder.Name} at {Name}.");
    }
}
