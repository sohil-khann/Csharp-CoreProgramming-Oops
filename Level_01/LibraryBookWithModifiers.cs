/*
 * LEVEL 2 PRACTICE - ACCESS MODIFIERS - PROBLEM 2: Book Library System
 * Design a Book class with:
 * - ISBN (public)
 * - title (protected)
 * - author (private)
 * Implement methods to:
 * - Set and get the author name.
 * - Create a subclass EBook to access ISBN and title and demonstrate access modifiers.
 */

namespace PracticePrograms
{
    public class LibraryBookWithModifiers
    {//instance variables with different access modifiers
        public string ISBN { get; set; }
        protected string Title { get; set; }
        private string author;

        //parameterized constructor
        public LibraryBookWithModifiers(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            this.author = author;
        }

        public string GetAuthor()
        {
            return author;
        }

        public void SetAuthor(string newAuthor)
        {
            author = newAuthor;
            Console.WriteLine($"Author updated to: {author}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ISBN: {ISBN}, Title: {Title}, Author: {author}");
        }
    }
    //subclass EBook
    public class EBook : LibraryBookWithModifiers
    {
        public string FileFormat { get; set; }

        public EBook(string isbn, string title, string author, string fileFormat)
            : base(isbn, title, author)
        {
            FileFormat = fileFormat;
        }
        //method to display eBook info
        public void DisplayEBookInfo()
        {
            Console.WriteLine($"ISBN: {ISBN}, Title: {Title}, Author: {GetAuthor()}, Format: {FileFormat}");
        }
    }
}
