using System;

namespace HybridInheritance
{
    // Superclass Vehicle
    public class Vehicle
    {
        public int MaxSpeed { get; set; }
        public string Model { get; set; }

        public Vehicle(int maxSpeed, string model)
        {
            MaxSpeed = maxSpeed;
            Model = model;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}, Max Speed: {MaxSpeed} km/h");
        }
    }

    // Interface Refuelable
    public interface IRefuelable
    {
        void Refuel();
    }

    // Subclass ElectricVehicle
    public class ElectricVehicle : Vehicle
    {
        public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

        public void Charge()
        {
            Console.WriteLine($"{Model} is charging its battery.");
        }
    }

    // Subclass PetrolVehicle implementing Refuelable
    public class PetrolVehicle : Vehicle, IRefuelable
    {
        public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

        public void Refuel()
        {
            Console.WriteLine($"{Model} is refueling with petrol.");
        }
    }
}
