/*2. E-Commerce Platform
Description: Develop a simplified e-commerce platform:
 Create an abstract class Product with fields like productId, name, and price, and an
abstract method CalculateDiscount().
 Extend it into concrete classes: Electronics, Clothing, and Groceries.
 Implement an interface ITaxable with methods CalculateTax() and GetTaxDetails() for
applicable product categories.
 Use encapsulation to protect product details, allowing updates only through setter
methods.
 Showcase polymorphism by creating a method that calculates and prints the final price
(price + tax - discount) for a list of products.*/

using System;
// Abstract class Product
public abstract class Product
{
       public int ProdId { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public Product(int prodId, string name, decimal price)
    {
        ProdId = prodId;
        Name = name;
        Price = price;
    }
    // Abstract method to calculate discount
    public abstract decimal CalculateDiscount();

}
// Interface ITaxable
public interface ITaxable
{
    int CalculateTax();
    string GetTaxDetails();
}
// Electronics class
public class Electronics : Product, ITaxable
{
    private const decimal discountRate = 0.05m; // 5% discount
    private const int taxRate = 15; // 15% tax
    public Electronics(int prodId, string name, decimal price)
        : base(prodId, name, price)
    {
    }
    // Implement CalculateDiscount
    public override decimal CalculateDiscount()
    {
        return Price * discountRate;
    }
    // Implement ITaxable methods
    public int CalculateTax()
    {
        return (int)(Price * taxRate / 100);
    }
    public string GetTaxDetails()
    {
        return $"Electronics Tax Rate: {taxRate}%";
    }
}
// Clothing class
public class Clothing : Product, ITaxable
{
    private const decimal discountRate = 0.2m; // 20% discount
    private const int taxRate = 5; // 5% tax
    public Clothing(int prodId, string name, decimal price)
        : base(prodId, name, price)
    {
    }
    // Implement CalculateDiscount
    public override decimal CalculateDiscount()
    {
        return Price * discountRate;
    }
    // Implement ITaxable methods
    public int CalculateTax()
    {
        return (int)(Price * taxRate / 100);
    }
    public string GetTaxDetails()
    {
        return $"Clothing Tax Rate: {taxRate}%";
    }
}
// Groceries class
public class Groceries : Product
{
    private const decimal discountRate = 0.05m; // 5% discount
    public Groceries(int prodId, string name, decimal price)
        : base(prodId, name, price)
    {
    }
    // Implement CalculateDiscount
    public override decimal CalculateDiscount()
    {
        return Price * discountRate;
    }
}
      