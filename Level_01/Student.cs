/*
 * LEVEL 2 PRACTICE - ACCESS MODIFIERS - PROBLEM 1: University Management System
 * Create a Student class with:
 * - rollNumber (public)
 * - name (protected)
 * - CGPA (private)
 * Implement methods to:
 * - Access and modify CGPA using public methods.
 * - Create a subclass PostgraduateStudent to demonstrate the use of protected members.
 */

namespace PracticePrograms
{
    public class Student
    {
        public int RollNumber { get; set; }
        protected string Name { get; set; }
        private decimal cgpa;

        public Student(int rollNumber, string name, decimal cgpa)
        {
            RollNumber = rollNumber;
            Name = name;
            this.cgpa = cgpa;
        }

        public decimal GetCGPA()
        {
            return cgpa;
        }

        public void SetCGPA(decimal newCGPA)
        {
            if (newCGPA >= 0 && newCGPA <= 4.0m)
            {
                cgpa = newCGPA;
                Console.WriteLine($"CGPA updated to {cgpa}");
            }
            else
            {
                Console.WriteLine("Invalid CGPA value. CGPA must be between 0 and 4.0");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Roll Number: {RollNumber}, Name: {Name}, CGPA: {cgpa}");
        }
    }

    public class PostgraduateStudent : Student
    {
        public string Specialization { get; set; }

        public PostgraduateStudent(int rollNumber, string name, decimal cgpa, string specialization)
            : base(rollNumber, name, cgpa)
        {
            Specialization = specialization;
        }

        public void DisplayPostgradInfo()
        {
            Console.WriteLine($"Name: {Name}, Roll Number: {RollNumber}, Specialization: {Specialization}, CGPA: {GetCGPA()}");
        }
    }
}
