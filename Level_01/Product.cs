/*
 * LEVEL 2 PRACTICE - PROBLEM 1: Product Inventory
 * Create a Product class with:
 * - Instance Variables: productName, price.
 * - Class Variable: totalProducts (shared among all products).
 * Implement the following methods:
 * - An instance method DisplayProductDetails() to display the details of a product.
 * - A class method DisplayTotalProducts() to show the total number of products created.
 */

namespace PracticePrograms
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        private static int totalProducts = 0;

        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
            totalProducts++;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product: {ProductName}, Price: ${Price}");
        }

        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products Created: {totalProducts}");
        }

        public static int GetTotalProductCount()
        {
            return totalProducts;
        }
    }
}
