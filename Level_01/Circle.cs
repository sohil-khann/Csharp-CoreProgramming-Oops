/*
 * LEVEL 1 PRACTICE - PROBLEM 2: Circle Class
 * Write a Circle class with a radius attribute.
 * Use constructor chaining to initialize radius with both default and user-provided values.
 */

namespace PracticePrograms
{
    public class Circle
    {
        //getter and setter for radius
        public double Radius { get; set; }

        //default constructor chaining to parameterized constructor
        public Circle() : this(1.0)
        {
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        //method to display circle info
        public void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius {Radius}: Area = {GetArea():F2}, Circumference = {GetCircumference():F2}");
        }
    }
}
