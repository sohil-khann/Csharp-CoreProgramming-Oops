using System;
using System.Collections.Generic;
using Oops_Pillars;

namespace Oops_Pillars_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
//problem 1:
/*
// Create a list of employees
List<Employee> employees = new List<Employee>();
employees.Add(new FullTimeEmployee(1, "sohil", 60000));
employees.Add(new PartTimeEmployee(2, "Raj", 20, 80));

((IDepartment)employees[0]).AssignDepartment("HR");
((IDepartment)employees[1]).AssignDepartment("IT");
// Display details and salaries
foreach (var employee in employees)
{
    employee.DisplayDetails();
    Console.WriteLine($"Calculated Salary: {employee.CalculateSalary():C}");
    Console.WriteLine(((IDepartment)employee).GetDepartmentDetails());
    Console.WriteLine();
}
*/


//Problem 2:
// Create a list of products
//List<Product> products = new List<Product>();
//products.Add(new Electronics(1, "Laptop", 1000m));
//products.Add(new Clothing(2, "Jeans", 50m));
//products.Add(new Groceries(3, "Apples", 5m));
//// Calculate and print final prices
//foreach (var product in products)
//{
//    decimal discount = product.CalculateDiscount();
//    int tax = 0;
//    string taxDetails = "No tax applicable";
//    if (product is ITaxable taxableProduct)
//    {
//        tax = taxableProduct.CalculateTax();
//        taxDetails = taxableProduct.GetTaxDetails();
//    }
//    decimal finalPrice = product.Price + tax - discount;
//    Console.WriteLine($"Product: {product.Name}");
//    Console.WriteLine($"Base Price: {product.Price:C}");
//    Console.WriteLine($"Discount: {discount}");
//    Console.WriteLine(taxDetails);
//    Console.WriteLine($"Final Price: {finalPrice:C}");
//    Console.WriteLine();
//}

            // Problem 3: Vehicle Rental System
            Console.WriteLine("\n--- Problem 3: Vehicle Rental System ---");
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("C101", 1000m),
                new Bike("B202", 500m),
                new Truck("T303", 2000m)
            };

            foreach (var vehicle in vehicles)
            {
                int days = 5;
                decimal rentalCost = vehicle.CalculateRentalCost(days);
                Console.WriteLine("Vehicle: " + vehicle.Type + ", No: " + vehicle.VehicleNumber);
                Console.WriteLine("Rental Cost for " + days + " days: " + rentalCost);
                
                if (vehicle is IInsurable insurable)
                {
                    Console.WriteLine("Insurance Cost: " + insurable.CalculateInsurance());
                    Console.WriteLine(insurable.GetInsuranceDetails());
                }
                Console.WriteLine();
            }

            // Problem 4: Banking System
            Console.WriteLine("\n--- Problem 4: Banking System ---");
            List<BankAccount> accounts = new List<BankAccount>
            {
                new SavingsAccount("SAV001", "Alice", 10000),
                new CurrentAccount("CUR002", "Bob", 5000)
            };

            foreach (var acc in accounts)
            {
                acc.DisplayAccountDetails();
                acc.Deposit(1000);
                acc.Withdraw(2000);
                
                if (acc is ILoanable loanable)
                {
                    Console.WriteLine("Loan Eligibility: " + loanable.CalculateLoanEligibility());
                    loanable.ApplyForLoan(5000);
                }
                Console.WriteLine();
            }

            // // Problem 5: Library Management System
            // Console.WriteLine("\n--- Problem 5: Library Management System ---");
            // List<LibraryItem> libraryItems = new List<LibraryItem>
            // {
            //     new Book("B001", "The C# Player's Guide", "RB Whitaker"),
            //     new Magazine("M001", "Tech Monthly", "Various"),
            //     new DVD("D001", "Inception", "Christopher Nolan")
            // };

            // foreach (var item in libraryItems)
            // {
            //     item.GetItemDetails();
            //     Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
                
            //     if (item is IReservable reservable)
            //     {
            //         reservable.ReserveItem("John Doe");
            //     }
            //     Console.WriteLine();
            // }

            // // Problem 6: Online Food Delivery System
            // Console.WriteLine("\n--- Problem 6: Online Food Delivery System ---");
            // List<FoodItem> cart = new List<FoodItem>
            // {
            //     new VegItem("Paneer Tikka", 250.0, 2),
            //     new NonVegItem("Chicken Biryani", 350.0, 1)
            // };

            // foreach (var food in cart)
            // {
            //     food.GetItemDetails();
            //     if (food is IDiscountable discountable)
            //     {
            //         discountable.ApplyDiscount(10);
            //         Console.WriteLine(discountable.GetDiscountDetails());
            //     }
            //     Console.WriteLine("Total Price (after discount/charges): " + food.CalculateTotalPrice());
            //     Console.WriteLine();
            // }

            // // Problem 7: Hospital Patient Management
            // Console.WriteLine("\n--- Problem 7: Hospital Patient Management ---");
            // List<Patient> patients = new List<Patient>
            // {
            //     new InPatient("P101", "Charlie", 45, 3),
            //     new OutPatient("P102", "Diana", 30)
            // };

            // foreach (var p in patients)
            // {
            //     p.GetPatientDetails();
            //     p.SetDiagnosis("General Fever");
                
            //     if (p is IMedicalRecord record)
            //     {
            //         record.AddRecord("Prescribed Paracetamol");
            //         record.ViewRecords();
            //     }
            //     Console.WriteLine("Final Bill: " + p.CalculateBill());
            //     Console.WriteLine();
            // }

            // // Problem 8: Ride-Hailing Application
            // Console.WriteLine("\n--- Problem 8: Ride-Hailing Application ---");
            // List<RideVehicle> rides = new List<RideVehicle>
            // {
            //     new CarRide("RIDE-C-01", "Sam"),
            //     new BikeRide("RIDE-B-01", "Max"),
            //     new AutoRide("RIDE-A-01", "Tom")
            // };

            // foreach (var ride in rides)
            // {
            //     ride.GetVehicleDetails();
            //     double dist = 10.5;
            //     Console.WriteLine("Fare for " + dist + " km: " + ride.CalculateFare(dist));
                
            //     if (ride is IGPS gps)
            //     {
            //         Console.WriteLine("Current Location: " + gps.GetCurrentLocation());
            //         gps.UpdateLocation("Airport Terminal 1");
            //     }
            //     Console.WriteLine();
            // }

            Console.ReadKey();
        }
    }
}
