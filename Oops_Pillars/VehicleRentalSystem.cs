/*3. Vehicle Rental System
Description: Design a system to manage vehicle rentals:
 Define an abstract class Vehicle with fields like vehicleNumber, type, and rentalRate.
 Add an abstract method CalculateRentalCost(int days).
 Create subclasses Car, Bike, and Truck with specific implementations of
CalculateRentalCost().
 Use an interface IInsurable with methods CalculateInsurance() and
GetInsuranceDetails().
 Apply encapsulation to restrict access to sensitive details like insurance policy
numbers.
 Demonstrate polymorphism by iterating over a list of vehicles and calculating rental and
insurance costs for each.*/

using System;

namespace Oops_Pillars
{
    // Abstract class Vehicle
    public abstract class Vehicle
    {
        private string vehicleNumber;
        private string vehicleType;
        private decimal rentalRatePerDay;

        public string VehicleNumber
        {
            get { return vehicleNumber; }
        }

        public string Type
        {
            get { return vehicleType; }
        }

        public decimal RentalRate
        {
            get { return rentalRatePerDay; }
        }

        public Vehicle(string vNumber, string vType, decimal rRate)
        {
            vehicleNumber = vNumber;
            vehicleType = vType;
            rentalRatePerDay = rRate;
        }

        // Abstract method to calculate rental cost
        public abstract decimal CalculateRentalCost(int days);
    }

    // Interface IInsurable
    public interface IInsurable
    {
        decimal CalculateInsurance();
        string GetInsuranceDetails();
    }

    // Car class
    public class Car : Vehicle, IInsurable
    {
        private decimal insurancePercentage;

        public Car(string vehicleNumber, decimal rentalRate)
            : base(vehicleNumber, "Car", rentalRate)
        {
            insurancePercentage = 10.0m;
        }

        // Implement CalculateRentalCost
        public override decimal CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        // Implement IInsurable methods
        public decimal CalculateInsurance()
        {
            return CalculateRentalCost(1) * (insurancePercentage / 100);
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance Rate: " + insurancePercentage + "% of daily rental cost";
        }
    }

    // Bike class
    public class Bike : Vehicle, IInsurable
    {
        private decimal insurancePercentage;

        public Bike(string vehicleNumber, decimal rentalRate)
            : base(vehicleNumber, "Bike", rentalRate)
        {
            insurancePercentage = 5.0m;
        }

        // Implement CalculateRentalCost
        public override decimal CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        // Implement IInsurable methods
        public decimal CalculateInsurance()
        {
            return CalculateRentalCost(1) * (insurancePercentage / 100);
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance Rate: " + insurancePercentage + "% of daily rental cost";
        }
    }

    // Truck class
    public class Truck : Vehicle, IInsurable
    {
        private decimal insurancePercentage;

        public Truck(string vehicleNumber, decimal rentalRate)
            : base(vehicleNumber, "Truck", rentalRate)
        {
            insurancePercentage = 15.0m;
        }

        // Implement CalculateRentalCost
        public override decimal CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        // Implement IInsurable methods
        public decimal CalculateInsurance()
        {
            return CalculateRentalCost(1) * (insurancePercentage / 100);
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance Rate: " + insurancePercentage + "% of daily rental cost";
        }
    }
}


