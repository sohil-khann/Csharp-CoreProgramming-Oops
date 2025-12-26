/*. Program to Handle Book Details
Problem Statement: Write a program to create a Book class with attributes title, author, and
price. Add a method to display the book details.*/

//create object 
List<Book> book = new List<Book>();

Console.WriteLine("How many books do you want to add :");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{

    Console.WriteLine($"Enter details for book {i + 1}:");
    Console.Write("Enter title: ");
    String title = Console.ReadLine();
    Console.Write("Enter Author Name: ");
    String author = Console.ReadLine();
    Console.Write("Enter price: ");
    int price = Convert.ToInt32(Console.ReadLine());
    Book b = new Book(title, author, price);
    book.Add(b);
}


foreach (Book s in book)
{
    Console.WriteLine(s.Details());

}