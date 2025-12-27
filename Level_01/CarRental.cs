/*
 * LEVEL 1 PRACTICE - PROBLEM 6: Car Rental System
 * Create a CarRental class with attributes customerName, carModel, and rentalDays.
 * Add constructors to initialize the rental details and calculate total cost.
 */

namespace PracticePrograms
{
    public class CarRental
    {
        public string CustomerName { get; set; }
        public string CarModel { get; set; }
        public int RentalDays { get; set; }
        private const decimal DailyRate = 50m;

        public CarRental(string customerName, string carModel, int rentalDays)
        {
            CustomerName = customerName;
            CarModel = carModel;
            RentalDays = rentalDays;
        }

        public decimal CalculateTotalCost()
        {
            return DailyRate * RentalDays;
        }

        public void DisplayRentalInfo()
        {
            Console.WriteLine($"Customer: {CustomerName}, Car: {CarModel}, Days: {RentalDays}, Total Cost: ${CalculateTotalCost()}");
        }
    }
}
