using System;

/*
Sample Program 5: University Student Management
Create a Student class to manage student data with the following features:
 static:
     A static variable UniversityName shared across all students.
     A static method DisplayTotalStudents() to show the number of students enrolled.
 this:
     Use this in the constructor to initialize Name, RollNumber, and Grade.
 readonly:
     Use a readonly variable RollNumber for each student that cannot be changed.
 is operator:
     Check if a given object is an instance of the Student class before performing operations like displaying or updating grades.
*/

namespace Level_01
{
    public class Student
    {
        public static string UniversityName = "State University";
        private static int studentCount = 0;

        public string Name;
        public readonly int RollNumber;
        public char Grade;

        public Student(string Name, int RollNumber, char Grade)
        {
            this.Name = Name;
            this.RollNumber = RollNumber;
            this.Grade = Grade;
            studentCount++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"\nTotal Students Enrolled at {UniversityName}: {studentCount}");
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("--- Student Academic Record ---");
            Console.WriteLine($"University: {UniversityName}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Roll Number: {this.RollNumber}");
            Console.WriteLine($"Grade: {this.Grade}");
        }
    }

    public class StudentManagementSystem
    {
        public static void Run()
        {
            Console.WriteLine($"University Portal - {Student.UniversityName}");

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            int roll = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Grade (A/B/C/D/F): ");
            char grade = char.Parse(Console.ReadLine() ?? "F");

            object studentObj = new Student(name, roll, grade);

            // Using 'is' to verify student instance
            if (studentObj is Student validStudent)
            {
                validStudent.DisplayStudentInfo();
            }
            else
            {
                Console.WriteLine("Invalid operation: Not a Student instance.");
            }

            Student.DisplayTotalStudents();
        }
    }
}
