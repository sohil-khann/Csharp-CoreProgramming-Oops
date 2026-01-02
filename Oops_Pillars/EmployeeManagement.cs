/*1. Employee Management System
Description: Build an employee management system with the following requirements:
 Use an abstract class Employee with fields like employeeId, name, and baseSalary.
 Provide an abstract method CalculateSalary() and a concrete method
DisplayDetails().
 Create two subclasses: FullTimeEmployee and PartTimeEmployee, implementing
CalculateSalary() based on work hours or fixed salary.
 Use encapsulation to restrict direct access to fields and provide properties for access.
 Create an interface IDepartment with methods like AssignDepartment() and
GetDepartmentDetails().
 Ensure polymorphism by processing a list of employees and displaying their details
using the Employee reference.
*/
using System;

// Abstract class Employee
public abstract class Employee
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int baseSalary { get; private set; }
    public Employee(int id, string name, int basesalary)
    {
        Id = id;
        Name = name;
        baseSalary = basesalary;
    }
    // Abstract method to calculate salary
    public abstract decimal CalculateSalary();
    // Concrete method to display details
    public void DisplayDetails()
    {
        Console.WriteLine($"Employee ID: {Id}, Name: {Name}, Base Salary: {baseSalary}");
    }
}

// Interface IDepartment
public interface IDepartment
{
    void AssignDepartment(string deptName);
    string GetDepartmentDetails();
}

// FullTimeEmployee class
public class FullTimeEmployee : Employee, IDepartment
{
    private string departmentName;
    // Constructor
    public FullTimeEmployee(int Id, string name, int baseSalary)
        : base(Id, name, baseSalary)
    {
    }
    // Implement CalculateSalary
    public override decimal CalculateSalary()
    {
        return baseSalary;
    }
    // Implement IDepartment methods
    public void AssignDepartment(string departmentName)
    {
        this.departmentName = departmentName;
    }
    public string GetDepartmentDetails()
    {
        return $"Department: {departmentName}";
    }
}

// PartTimeEmployee class
public class PartTimeEmployee : Employee, IDepartment
{
    private int workHours;
    private int hourlyRate;
    private string deptName;
    // Constructor
    public PartTimeEmployee(int Id, string name, int hourlyRate, int workHours)
        : base(Id, name, 0)
    {
        this.hourlyRate = hourlyRate;
        this.workHours = workHours;
    }
    // Implement CalculateSalary
    public override decimal CalculateSalary()
    {
        return hourlyRate * workHours;
    }
    // Implement IDepartment methods
    public void AssignDepartment(string deptName)
    {
        this.deptName = deptName;
    }
    public string GetDepartmentDetails()
    {
        return $"Department: {deptName}";
    }
}

