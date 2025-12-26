using System;

public class Book
{
    String title;
    String author;
    int price;
    public Book(String title,String author,int price)
    {
               this.title = title;
        this.author = author;
        this.price = price;

    }
    public String Details()
    {
        return $"Title : {title}, Auther : {author}, Price {price}";
    }
}