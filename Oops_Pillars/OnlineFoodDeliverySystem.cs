using System;

/*
6. Online Food Delivery System
Description: Create an online food delivery system:
● Define an abstract class FoodItem with fields like itemName, price, and quantity.
● Add abstract methods CalculateTotalPrice() and concrete methods like GetItemDetails().
● Extend it into classes VegItem and NonVegItem, overriding CalculateTotalPrice() to include additional charges.
● Use an interface IDiscountable with methods ApplyDiscount() and GetDiscountDetails().
● Use polymorphism to handle different types of food items dynamically.
*/

namespace Oops_Pillars
{
    // Interface for applying discounts
    public interface IDiscountable
    {
        void ApplyDiscount(double percentage);
        string GetDiscountDetails();
    }

    // Abstract class for any food item
    public abstract class FoodItem
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public FoodItem(string name, double itemPrice, int qty)
        {
            ItemName = name;
            Price = itemPrice;
            Quantity = qty;
        }

        // Each food type might have extra charges (like non-veg handling)
        public abstract double CalculateTotalPrice();

        public virtual void GetItemDetails()
        {
            Console.WriteLine("Item: " + ItemName + " | Price: " + Price + " | Quantity: " + Quantity);
        }
    }

    // Vegetarian items
    public class VegItem : FoodItem, IDiscountable
    {
        private double discount = 0;

        public VegItem(string name, double price, int qty) : base(name, price, qty) { }

        public override double CalculateTotalPrice()
        {
            double total = Price * Quantity;
            return total - (total * discount / 100);
        }

        public void ApplyDiscount(double percentage)
        {
            discount = percentage;
        }

        public string GetDiscountDetails()
        {
            return "Veg Item Discount: " + discount + "%";
        }
    }

    // Non-vegetarian items with extra charges
    public class NonVegItem : FoodItem, IDiscountable
    {
        private double handlingCharge = 50.0; // Extra charge for non-veg items
        private double discount = 0;

        public NonVegItem(string name, double price, int qty) : base(name, price, qty) { }

        public override double CalculateTotalPrice()
        {
            double total = (Price * Quantity) + handlingCharge;
            return total - (total * discount / 100);
        }

        public void ApplyDiscount(double percentage)
        {
            discount = percentage;
        }

        public string GetDiscountDetails()
        {
            return "Non-Veg Discount: " + discount + "% (Includes extra handling charge of " + handlingCharge + ")";
        }
    }
}
