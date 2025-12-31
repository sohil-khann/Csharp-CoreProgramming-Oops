/*Problem 1: Library and Books (Aggregation)
Description: Create a Library class that contains multiple Book objects. Model the
relationship such that a library can have many books, but a book can exist independently
(outside of a specific library).
Tasks:
 Define a Library class with a List<Book> collection.
 Define a Book class with attributes such as Title and Author.
 Demonstrate the aggregation relationship by creating books and adding them to
different libraries.
Goal: Understand aggregation by modeling a real-world relationship where the Library
aggregates Book objects.*/


using System.Collections.Generic;
using System;
// Define the Library class
internal class Library{

   
    private string Name;
    private List<Book> books;
    // Constructor
    public Library(string name)
    {
        Name = name;
        books = new List<Book>();
    }
    public void AddBook(Book book){
        books.Add(book);
    }// Method to display all books in the library
    public void DisplayBooks(){
        Console.WriteLine($"Books in {Name}:");
        foreach(var book in books){
            Console.WriteLine($"- {book.Title} by {book.Author}");
        }
    }

}// Define the Book class
internal class Book{
    public string Title {get; private set;}
    public string Author {get; private set;}
    public Book(string title, string author){
        Title = title;
        Author = author;
    }
}
