using System;

/*
Sample Program 2: Library Management System
Create a Book class to manage library books with the following features:
 static:
     A static variable LibraryName shared across all books.
     A static method DisplayLibraryName() to print the library name.
 this:
     Use this to initialize Title, Author, and ISBN in the constructor.
 readonly:
     Use a readonly variable ISBN to ensure the unique identifier of a book cannot be changed.
 is operator:
     Verify if an object is an instance of the Book class before displaying its details.
*/

namespace Level_01
{
    public class Book
    {
        public static string LibraryName = "Central City Library";
        
        public string Title;
        public string Author;
        public readonly string ISBN;

        public Book(string Title, string Author, string ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        public static void DisplayLibraryName()
        {
            Console.WriteLine($"\nLibrary: {LibraryName}");
        }

        public void ShowBookInfo()
        {
            Console.WriteLine("--- Book Information ---");
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Author: {this.Author}");
            Console.WriteLine($"ISBN: {this.ISBN}");
        }
    }

    public class LibraryManagementSystem
    {
        public static void Run()
        {
            Book.DisplayLibraryName();

            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();

            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine();

            object potentialBook = new Book(title, author, isbn);

            // Checking if the object is an instance of Book using 'is'
            if (potentialBook is Book validBook)
            {
                validBook.ShowBookInfo();
            }
            else
            {
                Console.WriteLine("Error: Invalid book object provided.");
            }
        }
    }
}
