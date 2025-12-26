using System;

    //poco class
    public class EmployeeDetail
    {
        //attributes
        public int EmployeeID;
        public string FullName;
        public int Salary;
        //constructor
        public EmployeeDetail(int EmployeeID, string FullName,int Salary)
        {
            //initialize attributes
            this.EmployeeID = EmployeeID;
         this.FullName = FullName;
            this.Salary = Salary;
        }

    //method to display details
    public string ToString()
        {
            return $"ID: {EmployeeID}, Name: {FullName}, Salary: {Salary}";
        }
    }
