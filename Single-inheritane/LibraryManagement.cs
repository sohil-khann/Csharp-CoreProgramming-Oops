using System;

namespace SingleInheritance
{
    // Superclass Book
    public class Book
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }
    }

    // Subclass Author extending Book
    public class Author : Book
    {
        public string Name { get; set; }
        public string Bio { get; set; }

        public Author(string title, int publicationYear, string name, string bio) 
            : base(title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
            Console.WriteLine($"Author Name: {Name}");
            Console.WriteLine($"Author Bio: {Bio}");
        }
    }
}
