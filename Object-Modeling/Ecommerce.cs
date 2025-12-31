/*Problem 4: E-commerce Platform with Orders, Customers, and Products
Description: Design an e-commerce platform with Order, Customer, and Product classes.
Model relationships where a Customer places an Order, and each Order contains multiple
Product objects.
Goal: Show communication and object relationships by designing a system where customers
communicate through orders, and orders aggregate products.*/
using System;

internal class Ecommerce
{
    private List<Order> orders;
    // Constructor
    public Ecommerce()
    {
        orders = new List<Order>();
    }
    public void PlaceOrder(Customer customer, Order order, Product product)
    {
        orders.Add(order);
        Console.WriteLine($"Customer {customer.Name} placed an order with ({product.Name}) products on price {product.Price}.");
        Console.WriteLine($"Total Orders: {order.Products.Count}");
    }
}

// // Define the Customer class
internal class Customer
{
    public string Name { get; private set; }
    // Constructor
    public Customer(string name)
    {
        Name = name;
    }
}
// // Define the Order class
internal class Order
{
    public List<Product> Products { get; private set; }
    // Constructor
    public Order()
    {
        Products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
}
// // Define the Product class
internal class Product
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    // Constructor
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}
