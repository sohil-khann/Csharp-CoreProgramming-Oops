using System;

/*
8. Ride-Hailing Application
Description: Develop a ride-hailing application.
● Abstract Class:
o Define an abstract class Vehicle with fields: vehicleId, driverName, and ratePerKm.
o Add an abstract method CalculateFare(double distance).
o Implement a concrete method GetVehicleDetails().
● Subclasses:
o Extend Vehicle into Car, Bike, and Auto.
o Override CalculateFare() based on type-specific rates.
● Interface:
o Implement an interface IGPS.
o Define methods GetCurrentLocation() and UpdateLocation().
● Encapsulation:
o Secure driver and vehicle details using private fields and properties.
● Polymorphism:
o Create a method that processes multiple vehicle types dynamically.
o Calculate fares based on the Vehicle reference.
*/

namespace Oops_Pillars
{
    // Interface for GPS functionality
    public interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string newAddress);
    }

    // Abstract class for any ride-hailing vehicle
    public abstract class RideVehicle
    {
        private string vehicleId;
        private string driverName;
        private double ratePerKm;

        public string VehicleId 
        { 
            get { return vehicleId; } 
        }
        
        public string DriverName 
        { 
            get { return driverName; } 
        }
        
        public double RatePerKm 
        { 
            get { return ratePerKm; } 
        }

        public RideVehicle(string id, string driver, double rate)
        {
            vehicleId = id;
            driverName = driver;
            ratePerKm = rate;
        }

        // Each vehicle type has its own way of calculating fare
        public abstract double CalculateFare(double distance);

        public virtual void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle ID: " + vehicleId + " | Driver: " + driverName + " | Rate per KM: " + ratePerKm);
        }
    }

    // Car ride implementation
    public class CarRide : RideVehicle, IGPS
    {
        private string location = "Main Street";

        public CarRide(string id, string driver) 
            : base(id, driver, 15.0) { } // 15 rupees per km

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public string GetCurrentLocation()
        {
            return location;
        }

        public void UpdateLocation(string newAddress)
        {
            location = newAddress;
            Console.WriteLine("Car " + VehicleId + " moved to " + newAddress);
        }
    }

    // Bike ride implementation
    public class BikeRide : RideVehicle, IGPS
    {
        private string location = "Station Road";

        public BikeRide(string id, string driver) 
            : base(id, driver, 8.0) { } // 8 rupees per km

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public string GetCurrentLocation()
        {
            return location;
        }

        public void UpdateLocation(string newAddress)
        {
            location = newAddress;
            Console.WriteLine("Bike " + VehicleId + " is now at " + newAddress);
        }
    }

    // Auto ride implementation
    public class AutoRide : RideVehicle, IGPS
    {
        private string location = "Central Square";

        public AutoRide(string id, string driver) 
            : base(id, driver, 12.0) { } // 12 rupees per km

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public string GetCurrentLocation()
        {
            return location;
        }

        public void UpdateLocation(string newAddress)
        {
            location = newAddress;
            Console.WriteLine("Auto " + VehicleId + " reached " + newAddress);
        }
    }
}
