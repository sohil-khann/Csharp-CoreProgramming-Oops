using System;
using System.Collections.Generic;
using System.Text;


    internal class Circle
    {
        int radius;
      public  Circle(int r)
        {
            this.radius = r;
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
        public void Display()
        {
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area: " + CalculateArea());
            Console.WriteLine("Circumference: " + CalculateCircumference());
        }
    }

