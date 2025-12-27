/*
 * LEVEL 1 PRACTICE - PROBLEM 3: Person Class (Copy Constructor)
 * Create a Person class with a copy constructor that clones another person's attributes.
 */

namespace PracticePrograms
{
    public class Person
    {
        //instance variables
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        
        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }
        //copy constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
            City = other.City;
        }
        //method to display person info
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, City: {City}");
        }
    }
}
