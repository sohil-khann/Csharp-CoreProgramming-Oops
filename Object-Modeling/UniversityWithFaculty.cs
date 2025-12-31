/*Problem 2: University with Faculties and Departments (Composition and
Aggregation)
Description: Create a University with multiple Faculty members and Department objects.
Model it so that the University and its Departments are in a composition relationship
(deleting a university deletes all departments), and the Faculty members are in an
aggregation relationship (faculty can exist outside of any specific department).
Tasks:
 Define a University class with Department and Faculty classes.
 Demonstrate how deleting a University also deletes its Departments.
 Show that Faculty members can exist indeendently of a Department.
Goal: Understand the differences between composition and aggregation in modeling
complex hierarchical relationships.
*/

using System;
using System.Collections.Generic;
// Define the University class


internal class University
{
    private string Name;
    private List<Departments> departments;
    // Constructor
    public University(string name)
    {
        Name = name;
        departments = new List<Departments>();
    }
    public void AddDepartment(Departments department)
    {
        departments.Add(department);
    }
    // Method to display all departments
    public void DisplayDepartments()
    {
        Console.WriteLine($"University: {Name}");
        foreach (var dept in departments)
        {
            Console.WriteLine($"- Department: {dept.Name}");
        }
    }
}
// Define the Department class
internal class Departments
{
    public string Name { get; private set; }
    // Constructor
    public Departments(string name)
    {
        Name = name;
    }
}
// Define the Faculty class
internal class Faculty
{
    public string Name { get; private set; }
    // Constructor
    public Faculty(string name)
    {
        Name = name;
    }
}
 

