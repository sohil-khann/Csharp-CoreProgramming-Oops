/*
 * LEVEL 1 PRACTICE - PROBLEM 4: Hotel Booking System
 * Create a HotelBooking class with attributes guestName, roomType, and nights.
 * Use default, parameterized, and copy constructors to initialize bookings.
 */

namespace PracticePrograms
{
    public class HotelBooking
    {
        //instance variables
        public string GuestName { get; set; }
        public string RoomType { get; set; }
        public int Nights { get; set; }
        //default constructor
        public HotelBooking()
        {
            GuestName = "Guest";
            RoomType = "Standard";
            Nights = 1;
        }
        //parameterized constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            GuestName = guestName;
            RoomType = roomType;
            Nights = nights;
        }
        //copy constructor
        public HotelBooking(HotelBooking other)
        {
            GuestName = other.GuestName;
            RoomType = other.RoomType;
            Nights = other.Nights;
        }
        //method to display booking info
        public void DisplayBookingInfo()
        {
            Console.WriteLine($"Guest: {GuestName}, Room Type: {RoomType}, Nights: {Nights}");
        }
    }
}
