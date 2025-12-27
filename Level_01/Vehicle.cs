/*
 * LEVEL 2 PRACTICE - PROBLEM 3: Vehicle Registration
 * Create a Vehicle class to manage vehicle details:
 * - Instance Variables: ownerName, vehicleType.
 * - Class Variable: registrationFee (fixed for all vehicles).
 * Implement the following methods:
 * - An instance method DisplayVehicleDetails() to display owner and vehicle details.
 * - A class method UpdateRegistrationFee() to change the registration fee.
 */

namespace PracticePrograms
{
    public class Vehicle
    {
        //instance variables
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }
        private static decimal registrationFee = 500m;
        //parameterized constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }
        //instance method to display vehicle details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Owner: {OwnerName}, Vehicle Type: {VehicleType}, Registration Fee: ${registrationFee}");
        }
        //class method to update registration fee
        public static void UpdateRegistrationFee(decimal newFee)
        {
            registrationFee = newFee;
            Console.WriteLine($"Registration fee updated to: ${registrationFee}");
        }
        //class method to get registration fee
        public static decimal GetRegistrationFee()
        {
            return registrationFee;
        }
    }
}
