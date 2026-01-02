using System;

/*
5. Library Management System
Description: Develop a library management system:
● Use an abstract class LibraryItem with fields like itemId, title, and author.
● Add an abstract method GetLoanDuration() and a concrete method GetItemDetails().
● Create subclasses Book, Magazine, and DVD, overriding GetLoanDuration() with specific logic.
● Implement an interface IReservable with methods ReserveItem() and CheckAvailability().
● Apply encapsulation to secure details like the borrower’s personal data.
● Use polymorphism to allow a general LibraryItem reference to manage all items.
*/

namespace Oops_Pillars
{
    // Interface for items that can be reserved
    public interface IReservable
    {
        void ReserveItem(string personName);
        bool IsAvailableForRent();
    }

    // Abstract class for any item in the library
    public abstract class LibraryItem
    {
        private string itemId;
        private string title;
        private string author;
        protected bool isAvailable = true;
        private string borrowerName = "None";

        public string ItemId 
        { 
            get { return itemId; } 
        }
        
        public string Title 
        { 
            get { return title; } 
        }
        
        public string Author 
        { 
            get { return author; } 
        }

        public LibraryItem(string id, string bookTitle, string writer)
        {
            itemId = id;
            title = bookTitle;
            author = writer;
        }

        // Each item type has a different loan duration
        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine("ID: " + itemId + " | Title: " + title + " | Author: " + author + " | Status: " + (isAvailable ? "Available" : "Borrowed by " + borrowerName));
        }

        // Internal method to handle borrower data securely
        protected void UpdateBorrower(string name)
        {
            borrowerName = name;
        }
    }

    // Book class
    public class Book : LibraryItem, IReservable
    {
        public Book(string id, string title, string author) : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 14; // Books can be kept for 2 weeks
        }

        public void ReserveItem(string personName)
        {
            if (isAvailable)
            {
                isAvailable = false;
                UpdateBorrower(personName);
                Console.WriteLine("The book '" + Title + "' has been reserved for " + personName);
            }
            else
            {
                Console.WriteLine("Sorry, '" + Title + "' is already taken.");
            }
        }

        public bool IsAvailableForRent()
        {
            return isAvailable;
        }
    }

    // Magazine class
    public class Magazine : LibraryItem
    {
        public Magazine(string id, string title, string author) : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 7; // Magazines can only be kept for 1 week
        }
    }

    // DVD class
    public class DVD : LibraryItem, IReservable
    {
        public DVD(string id, string title, string author) : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 3; // DVDs must be returned in 3 days
        }

        public void ReserveItem(string personName)
        {
            if (isAvailable)
            {
                isAvailable = false;
                UpdateBorrower(personName);
                Console.WriteLine("The DVD '" + Title + "' is now reserved for " + personName);
            }
            else
            {
                Console.WriteLine("DVD '" + Title + "' is currently out.");
            }
        }

        public bool IsAvailableForRent()
        {
            return isAvailable;
        }
    }
}
