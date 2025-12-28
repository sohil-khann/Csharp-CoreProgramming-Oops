using System;

/*
Sample Program 3: Employee Management System
Design an Employee class with the following features:
 static:
     A static variable CompanyName shared by all employees.
     A static method DisplayTotalEmployees() to show the total number of employees.
 this:
     Use this to initialize Name, Id, and Designation in the constructor.
 readonly:
     Use a readonly variable Id for the employee ID, which cannot be modified after assignment.
 is operator:
     Check if a given object is an instance of the Employee class before printing the employee details.
*/

namespace Level_01
{
    public class Employee
    {
        public static string CompanyName = "Tech Solutions Inc.";
        private static int employeeCount = 0;

        public string Name;
        public readonly int Id;
        public string Designation;

        public Employee(string Name, int Id, string Designation)
        {
            this.Name = Name;
            this.Id = Id;
            this.Designation = Designation;
            employeeCount++;
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"\nTotal Employees at {CompanyName}: {employeeCount}");
        }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine("--- Employee Data ---");
            Console.WriteLine($"ID: {this.Id}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Designation: {this.Designation}");
            Console.WriteLine($"Company: {CompanyName}");
        }
    }

    public class EmployeeManagementSystem
    {
        public static void Run()
        {
            Console.WriteLine($"Welcome to {Employee.CompanyName} Employee Portal");

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee ID (numeric): ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Designation: ");
            string jobTitle = Console.ReadLine();

            object empObj = new Employee(name, id, jobTitle);

            // Verifying instance type with 'is'
            if (empObj is Employee empInstance)
            {
                empInstance.PrintEmployeeDetails();
            }
            else
            {
                Console.WriteLine("Fatal Error: Object is not a valid Employee.");
            }

            Employee.DisplayTotalEmployees();
        }
    }
}
