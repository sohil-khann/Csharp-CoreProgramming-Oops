/*
 * LEVEL 1 PRACTICE - PROBLEM 1: Book Class
 * Create a Book class with attributes title, author, and price.
 * Provide both default and parameterized constructors.
 */

namespace PracticePrograms
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Price = 0m;
        }

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}, Price: ${Price}");
        }
    }
}
