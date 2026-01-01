using System;

namespace HierarchicalInheritance
{
    // Superclass Person
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Subclass Teacher
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) 
            : base(name, age)
        {
            Subject = subject;
        }

        public void DisplayRole()
        {
            Console.WriteLine("Role: Teacher");
            DisplayInfo();
            Console.WriteLine($"Subject: {Subject}");
        }
    }

    // Subclass Student
    public class Student : Person
    {
        public string Grade { get; set; }

        public Student(string name, int age, string grade) 
            : base(name, age)
        {
            Grade = grade;
        }

        public void DisplayRole()
        {
            Console.WriteLine("Role: Student");
            DisplayInfo();
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    // Subclass Staff
    public class Staff : Person
    {
        public string Department { get; set; }

        public Staff(string name, int age, string department) 
            : base(name, age)
        {
            Department = department;
        }

        public void DisplayRole()
        {
            Console.WriteLine("Role: Staff");
            DisplayInfo();
            Console.WriteLine($"Department: {Department}");
        }
    }
}
