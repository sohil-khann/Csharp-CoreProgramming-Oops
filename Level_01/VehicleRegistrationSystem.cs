using System;

/*
Sample Program 6: Vehicle Registration System
Create a Vehicle class with the following features:
 static:
     A static variable RegistrationFee common for all vehicles.
     A static method UpdateRegistrationFee() to modify the fee.
 this:
     Use this to initialize OwnerName, VehicleType, and RegistrationNumber in the constructor.
 readonly:
     Use a readonly variable RegistrationNumber to uniquely identify each vehicle.
 is operator:
     Check if an object belongs to the Vehicle class before displaying its registration details.
*/

namespace Level_01
{
    public class Vehicle
    {
        public static double RegistrationFee = 250.0;

        public string OwnerName;
        public string VehicleType;
        public readonly string RegistrationNumber;

        public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
        {
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
            this.RegistrationNumber = RegistrationNumber;
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
            Console.WriteLine($"Registration fee updated to: ${RegistrationFee}");
        }

        public void DisplayRegistration()
        {
            Console.WriteLine("\n--- Vehicle Registration Record ---");
            Console.WriteLine($"Owner: {this.OwnerName}");
            Console.WriteLine($"Vehicle Type: {this.VehicleType}");
            Console.WriteLine($"Registration #: {this.RegistrationNumber}");
            Console.WriteLine($"Fee Paid: ${RegistrationFee}");
        }
    }

    public class VehicleRegistrationSystem
    {
        public static void Run()
        {
            Console.WriteLine("Vehicle Registration Authority");
            
            Console.Write("Update base registration fee? (Enter amount or 0 to keep current): ");
            double feeInput = double.Parse(Console.ReadLine() ?? "0");
            if (feeInput > 0) Vehicle.UpdateRegistrationFee(feeInput);

            Console.Write("Enter Owner Name: ");
            string owner = Console.ReadLine();

            Console.Write("Enter Vehicle Type (e.g., Sedan, SUV): ");
            string type = Console.ReadLine();

            Console.Write("Enter Registration Number: ");
            string regNo = Console.ReadLine();

            object vehicleData = new Vehicle(owner, type, regNo);

            // Checking instance with 'is'
            if (vehicleData is Vehicle v)
            {
                v.DisplayRegistration();
            }
            else
            {
                Console.WriteLine("Error: Invalid vehicle data format.");
            }
        }
    }
}
