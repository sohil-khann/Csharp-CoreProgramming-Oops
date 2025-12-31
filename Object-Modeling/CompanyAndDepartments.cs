using System;
using System.Collections.Generic;
/*Problem 3: Company and Departments (Composition)
Description: A Company has several Department objects, and each department contains
Employee objects. Model this using composition, where deleting a Company should also
delete all departments and employees.
Tasks:
 Define a Company class that contains multiple Department objects.
 Define an Employee class within each Department.
 Show the composition relationship by ensuring that when a Company object is
deleted, all associated Department and Employee objects are also removed.
Goal: Understand composition by implementing a relationship where Department and
Employee objects cannot exist without a Company.
*/
// Define the Company class
internal class Company
{
    private string Name;
    private List<Department> departments;
    // Constructor
    public Company(string name)
    {
        Name = name;
        departments = new List<Department>();
    }
    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }
    // Method to display all departments and their employees
    public void DisplayStructure()
    {
        Console.WriteLine($"Company: {Name}");
        foreach (var dept in departments)
        {
            dept.DisplayEmployees();
        }
    }
}
// Define the Department class
internal class Department
{
    private string Name;
    private List<Employee> employees;
    // Constructor
    public Department(string name)
    {
        Name = name;
        employees = new List<Employee>();
    }
    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }
    // Method to display all employees in the department
    public void DisplayEmployees()
    {
        Console.WriteLine($" Department: {Name}");
        foreach (var emp in employees)
        {
            Console.WriteLine($"  - {emp.Name}, Position: {emp.Position}");
        }
    }
}
// Define the Employee class
internal class Employee
{
    public string Name { get; private set; }
    public string Position { get; private set; }
    // Constructor
    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }
}


