/*1.Program to Display Employee Details
Problem Statement: Write a program to create an Employee class with attributes name, id,
and salary. Add a method to display the details.
*/

using System;
public class Program
{

    public static void Main(string[] args)
    {

        //create object of EmployeeDetail class

        List<EmployeeDetail> employees = new List<EmployeeDetail>();
        //EmployeeDetail emp = new EmployeeDetail(101, "Sohil khan ", 55000);

        Console.WriteLine("How many employees do you want to add :");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<n; i++)
        {

            Console.WriteLine($"Enter details for employee {i + 1}:");
            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Full Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            EmployeeDetail employee = new EmployeeDetail(id, name, salary);
            employees.Add(employee);
        }


        foreach(EmployeeDetail s in employees)
        {
            Console.WriteLine(s.ToString());

        }

    }
}