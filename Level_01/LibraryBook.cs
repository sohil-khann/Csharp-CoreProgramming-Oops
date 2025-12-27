/*
 * LEVEL 1 PRACTICE - PROBLEM 5: Library Book System
 * Create a Book class with attributes title, author, price, and availability.
 * Implement a method BorrowBook() to borrow a book.
 */

namespace PracticePrograms
{
    public class LibraryBook
    {
        //instance variables
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        //parameterized constructor
        public LibraryBook(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
            IsAvailable = true;
        }
        //method to borrow book
        public bool BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Book '{Title}' has been borrowed.");
                return true;
            }
            else
            {
                Console.WriteLine($"Book '{Title}' is not available for borrowing.");
                return false;
            }
        }

        public void ReturnBook()
        {
            IsAvailable = true;
            Console.WriteLine($"Book '{Title}' has been returned.");
        }
        //method to display book info
        public void DisplayInfo()
        {
            string status = IsAvailable ? "Available" : "Not Available";
            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: ${Price}, Status: {status}");
        }
    }
}
