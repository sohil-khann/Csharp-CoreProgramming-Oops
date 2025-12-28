using System;

/*
Sample Program 4: Shopping Cart System
Create a Product class to manage shopping cart items with the following features:
 static:
     A static variable Discount shared by all products.
     A static method UpdateDiscount() to modify the discount percentage.
 this:
     Use this to initialize ProductName, Price, and Quantity in the constructor.
 readonly:
     Use a readonly variable ProductID to ensure each product has a unique identifier that cannot be changed.
 is operator:
     Validate whether an object is an instance of the Product class before processing its details.
*/

namespace Level_01
{
    public class Product
    {
        public static double Discount = 5.0; // Default 5% discount

        public readonly string ProductID;
        public string ProductName;
        public double Price;
        public int Quantity;

        public Product(string ProductID, string ProductName, double Price, int Quantity)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
            Console.WriteLine($"Discount updated successfully to {Discount}%.");
        }

        public void DisplayProductDetails()
        {
            double totalPrice = (this.Price * this.Quantity);
            double finalPrice = totalPrice - (totalPrice * Discount / 100);

            Console.WriteLine("\n--- Shopping Cart Item ---");
            Console.WriteLine($"Product ID: {this.ProductID}");
            Console.WriteLine($"Product Name: {this.ProductName}");
            Console.WriteLine($"Unit Price: ${this.Price}");
            Console.WriteLine($"Quantity: {this.Quantity}");
            Console.WriteLine($"Current Discount: {Discount}%");
            Console.WriteLine($"Final Amount: ${finalPrice:F2}");
        }
    }

    public class ShoppingCartSystem
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to the E-Mart Shopping Cart");
            
            Console.Write("Set seasonal discount percentage: ");
            double disc = double.Parse(Console.ReadLine() ?? "0");
            Product.UpdateDiscount(disc);

            Console.Write("Enter Product ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Unit Price: ");
            double price = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Quantity: ");
            int qty = int.Parse(Console.ReadLine() ?? "0");

            object genericProduct = new Product(id, name, price, qty);

            // Using 'is' to validate the product object
            if (genericProduct is Product validProduct)
            {
                validProduct.DisplayProductDetails();
            }
            else
            {
                Console.WriteLine("Validation failed: The object is not a valid Product.");
            }
        }
    }
}
