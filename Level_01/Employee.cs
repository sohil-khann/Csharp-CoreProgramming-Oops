/*
 * LEVEL 2 PRACTICE - ACCESS MODIFIERS - PROBLEM 4: Employee Records
 * Develop an Employee class with:
 * - employeeID (public)
 * - department (protected)
 * - salary (private)
 * Implement methods to:
 * - Modify salary using a public method.
 * - Create a subclass Manager to access employeeID and department.
 */

namespace PracticePrograms
{
    public class Employee
    {
        //instance variables
        public string EmployeeID { get; set; }
        protected string Department { get; set; }
        private decimal salary;

        //parameterized constructor
        public Employee(string employeeID, string department, decimal salary)
        {
            EmployeeID = employeeID;
            Department = department;
            this.salary = salary;
        }

        public decimal GetSalary()
        {
            return salary;
        }
        //
        //public method to set salary
        public void SetSalary(decimal newSalary)
        {
            if (newSalary >= 0)
            {
                salary = newSalary;
                Console.WriteLine($"Salary updated to ${salary}");
            }
            else
            {
                Console.WriteLine("Salary must be a non-negative value");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}, Department: {Department}, Salary: ${salary}");
        }
    }
    //subclass Manager
    public class Manager : Employee
    {
        public int TeamSize { get; set; }
        //parameterized constructor
        public Manager(string employeeID, string department, decimal salary, int teamSize)
            : base(employeeID, department, salary)
        {
            TeamSize = teamSize;
        }

        //method to display manager info
        public void DisplayManagerInfo()
        {
            Console.WriteLine($"Manager ID: {EmployeeID}, Department: {Department}, Salary: ${GetSalary()}, Team Size: {TeamSize}");
        }
    }
}
