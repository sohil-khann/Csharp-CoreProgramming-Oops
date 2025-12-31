using System;

//Problem 1: Library and Books (Aggregation)
/*
// Create books
Book book1 = new Book("1984", "George Orwell");
Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
// Create libraries
Library library1 = new Library("City Library");
Library library2 = new Library("University Library");
// Add books to libraries
library1.AddBook(book1);
library1.AddBook(book2);
library2.AddBook(book2);
library2.AddBook(book3);
// Display library contents
library1.DisplayBooks();
library2.DisplayBooks();
*/

//Problem 2: Bank and Account Holders (Association)
/*
// Example usage:
Bank bank = new Bank("State Bank");
BankAccountHolder customer = new BankAccountHolder("Sohil", bank);
bank.OpenAccount(customer);
customer.Deposit(500);
customer.Withdraw(200);
customer.ViewBalance();

*/

//Problem 3: Company and Departments (Composition)
/*
// Example usage:
Company company = new Company("Tech Solutions");
Department dept1 = new Department("Research and Development");
Department dept2 = new Department("Marketing");
Employee emp1 = new Employee("Charan", "Engineer");
Employee emp2 = new Employee("Sohil", "Scientist");
dept1.AddEmployee(emp1);
dept2.AddEmployee(emp2);
dept2.AddEmployee(emp3);
company.AddDepartment(dept1);
company.AddDepartment(dept2);
company.DisplayStructure();
*/


//School and Students with Courses (Association and Aggregation)/
/*
// Create a school
School school = new School("Greenwood High");
// Create courses
Course math = new Course("Mathematics");
Course science = new Course("Science");
// Create students
Student alice = new Student("Sohil");
Student bob = new Student("Charan");
// Enroll students in courses
alice.EnrollInCourse(math);
alice.EnrollInCourse(science);
bob.EnrollInCourse(science);
// Add students to the school
alice.EnrollInCourse(science);
alice.EnrollInCourse(science);
alice.EnrollInCourse(science);
school.AddStudent(alice);
school.AddStudent(bob);
// Display enrolled courses for each student
school.AddStudent(alice);
alice.DisplayCourses();
bob.DisplayCourses();
alice.DisplayCourses();
// Display enrolled students for each course
math.DisplayStudents();
science.DisplayStudents();
bob.DisplayCourses();
science.DisplayStudents();
alice.DisplayCourses();
bob.DisplayCourses();
science.DisplayStudents();
math.DisplayStudents();
*/

//University with Faculties and Departments (Composition and Aggregation)
/*
University uni = new University("Tech University");
// Create departments
Departments csDept = new Departments("Computer Science");
Departments mathDept = new Departments("Mathematics");
// Add departments to the university
uni.AddDepartment(csDept);
uni.AddDepartment(mathDept);
// Display departments
uni.DisplayDepartments();
// Create faculty members
Faculty profSmith = new Faculty("Dr. Sohil");
Faculty profJohnson = new Faculty("Dr. Charan");
// Faculty members exist independently of departments
Console.WriteLine($"Faculty Member: {profSmith.Name}");
Console.WriteLine($"Faculty Member: {profJohnson.Name}");
*/

//Hospital, Doctors, and Patients (Association and Communication)
/*
Hospital hospital = new Hospital("City Hospital");

Doctor doctor1 = new Doctor("Dr. Sohil");
Doctor doctor2 = new Doctor("Dr. name");
Patient patient1 = new Patient("mareez");
Patient patient2 = new Patient("beemar");
hospital.AdmitPatient(doctor1, patient1);
hospital.AdmitPatient(doctor2, patient2);
*/

// Ecommerce Platform with Orders, Customers, and Products
/*
Ecommerce platform = new Ecommerce();
Customer customer = new Customer("Sohil");
Order order = new Order();
Product product1 = new Product("Laptop", 999.99m);
Product product2 = new Product("Mouse", 25.50m);
order.AddProduct(product1);
order.AddProduct(product2);
platform.PlaceOrder(customer, order, product1);
platform.PlaceOrder(customer, order, product2);
*/




Console.ReadKey();