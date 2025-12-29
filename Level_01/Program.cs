using PracticePrograms;

// LEVEL 1 - CONSTRUCTORS

// PROBLEM 1: Book Class
Console.WriteLine("--- Problem 1: Book Class ---");
Console.WriteLine("Create books using default and parameterized constructors\n");

Console.WriteLine("Creating default book:");
Book book1 = new Book();
book1.DisplayDetails();

Console.WriteLine("\nCreating book with your input:");
Console.Write("Enter book title: ");
string title = Console.ReadLine() ?? "Unknown";

Console.Write("Enter author name: ");
string author = Console.ReadLine() ?? "Unknown";

Console.Write("Enter book price: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal price))
    price = 0m;

Book book2 = new Book(title, author, price);
book2.DisplayDetails();

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();

/*
// PROBLEM 2: Circle Class - Constructor Chaining
Console.WriteLine("--- Problem 2: Circle Class ---");
Console.WriteLine("Learn about constructor chaining\n");

Console.WriteLine("Creating default circle (radius = 1.0):");
Circle circle1 = new Circle();
circle1.DisplayInfo();

Console.WriteLine("\nEnter a custom radius:");
Console.Write("Enter radius: ");
if (double.TryParse(Console.ReadLine(), out double radius))
{
    Circle circle2 = new Circle(radius);
    circle2.DisplayInfo();
}
else
{
    Console.WriteLine("Invalid input. Using default radius.");
    Circle circle2 = new Circle();
    circle2.DisplayInfo();
}

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

/*
// PROBLEM 3: Person Class - Copy Constructor
Console.WriteLine("--- Problem 3: Person Class (Copy Constructor) ---");
Console.WriteLine("Learn how to clone objects using copy constructor\n");

Console.WriteLine("Enter person details:");
Console.Write("Enter name: ");
string name = Console.ReadLine() ?? "Unknown";

Console.Write("Enter age: ");
if (!int.TryParse(Console.ReadLine(), out int age))
    age = 0;

Console.Write("Enter city: ");
string city = Console.ReadLine() ?? "Unknown";

Person person1 = new Person(name, age, city);
Console.WriteLine("\nOriginal Person:");
person1.DisplayInfo();

Console.WriteLine("\nCreating a copy using copy constructor:");
Person person2 = new Person(person1);
Console.WriteLine("Copied Person:");
person2.DisplayInfo();
Console.WriteLine("\nBoth objects have the same data now!");

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

/*
// PROBLEM 4: Hotel Booking System
Console.WriteLine("--- Problem 4: Hotel Booking System ---");
Console.WriteLine("Learn about default, parameterized, and copy constructors\n");

Console.WriteLine("Creating default booking:");
HotelBooking booking1 = new HotelBooking();
booking1.DisplayBookingInfo();

Console.WriteLine("\nEnter booking details:");
Console.Write("Enter guest name: ");
string guestName = Console.ReadLine() ?? "Guest";

Console.Write("Enter room type (Standard/Deluxe/Suite): ");
string roomType = Console.ReadLine() ?? "Standard";

Console.Write("Enter number of nights: ");
if (!int.TryParse(Console.ReadLine(), out int nights))
    nights = 1;

HotelBooking booking2 = new HotelBooking(guestName, roomType, nights);
Console.WriteLine("\nNew Booking:");
booking2.DisplayBookingInfo();

Console.WriteLine("\nCopying the booking using copy constructor:");
HotelBooking booking3 = new HotelBooking(booking2);
booking3.DisplayBookingInfo();

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

/*
// PROBLEM 5: Library Book System
Console.WriteLine("--- Problem 5: Library Book System ---");
Console.WriteLine("Learn about borrowing and returning books\n");

Console.Write("Enter book title: ");
string libTitle = Console.ReadLine() ?? "Unknown";

Console.Write("Enter author name: ");
string libAuthor = Console.ReadLine() ?? "Unknown";

Console.Write("Enter book price: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal libPrice))
    libPrice = 0m;

LibraryBook libBook = new LibraryBook(libTitle, libAuthor, libPrice);

Console.WriteLine("\nInitial book status:");
libBook.DisplayInfo();

Console.WriteLine("\nBorrowing the book:");
libBook.BorrowBook();
libBook.DisplayInfo();

Console.WriteLine("\nTrying to borrow again (should fail):");
libBook.BorrowBook();

Console.WriteLine("\nReturning the book:");
libBook.ReturnBook();
libBook.DisplayInfo();

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

/*
// PROBLEM 6: Car Rental System
Console.WriteLine("--- Problem 6: Car Rental System ---");
Console.WriteLine("Calculate total rental cost\n");

Console.Write("Enter customer name: ");
string customerName = Console.ReadLine() ?? "Customer";

Console.Write("Enter car model: ");
string carModel = Console.ReadLine() ?? "Unknown";

Console.Write("Enter number of rental days: ");
if (!int.TryParse(Console.ReadLine(), out int rentalDays))
    rentalDays = 1;

CarRental rental = new CarRental(customerName, carModel, rentalDays);
rental.DisplayRentalInfo();

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

/*
// LEVEL 2 - INSTANCE vs CLASS VARIABLES

// PROBLEM 7: Product Inventory
Console.WriteLine("--- Problem 7: Product Inventory ---");
Console.WriteLine("Learn about static class variables\n");

bool addMoreProducts = true;
int productCount = 0;

while (addMoreProducts)
{
    Console.Write("Enter product name: ");
    string productName = Console.ReadLine() ?? "Unknown";

    Console.Write("Enter product price: ");
    if (!decimal.TryParse(Console.ReadLine(), out decimal productPrice))
        productPrice = 0m;

    Product product = new Product(productName, productPrice);
    product.DisplayProductDetails();
    productCount++;

    Console.Write("\nAdd another product? (y/n): ");
    addMoreProducts = Console.ReadLine()?.ToLower() == "y";
}

Console.WriteLine("\n--- Total Products Summary ---");
Product.DisplayTotalProducts();

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

/*
// PROBLEM 8: Online Course Management
Console.WriteLine("--- Problem 8: Online Course Management ---");
Console.WriteLine("Learn about shared class variables\n");

Console.WriteLine($"Current Institute Name: {Course.GetInstituteName()}\n");

bool addMoreCourses = true;

while (addMoreCourses)
{
    Console.Write("Enter course name: ");
    string courseName = Console.ReadLine() ?? "Unknown";

    Console.Write("Enter duration (hours): ");
    if (!int.TryParse(Console.ReadLine(), out int duration))
        duration = 0;

    Console.Write("Enter course fee: ");
    if (!decimal.TryParse(Console.ReadLine(), out decimal fee))
        fee = 0m;

    Course course = new Course(courseName, duration, fee);
    course.DisplayCourseDetails();

    Console.Write("\nAdd another course? (y/n): ");
    addMoreCourses = Console.ReadLine()?.ToLower() == "y";
}

Console.Write("\nUpdate institute name? (y/n): ");
if (Console.ReadLine()?.ToLower() == "y")
{
    Console.Write("Enter new institute name: ");
    string newInstituteName = Console.ReadLine() ?? "Tech Academy";
    Course.UpdateInstituteName(newInstituteName);
    
    Console.WriteLine("\nNow all courses will show the new institute name!");
}

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

/*
// PROBLEM 9: Vehicle Registration
Console.WriteLine("--- Problem 9: Vehicle Registration ---");
Console.WriteLine("Learn about static member modification\n");

Console.WriteLine($"Current Registration Fee: ${Vehicle.GetRegistrationFee()}\n");

bool addMoreVehicles = true;

while (addMoreVehicles)
{
    Console.Write("Enter owner name: ");
    string ownerName = Console.ReadLine() ?? "Unknown";

    Console.Write("Enter vehicle type (Car/Bike/Bus): ");
    string vehicleType = Console.ReadLine() ?? "Unknown";

    Vehicle vehicle = new Vehicle(ownerName, vehicleType);
    vehicle.DisplayVehicleDetails();

    Console.Write("\nAdd another vehicle? (y/n): ");
    addMoreVehicles = Console.ReadLine()?.ToLower() == "y";
}

Console.Write("\nUpdate registration fee for all vehicles? (y/n): ");
if (Console.ReadLine()?.ToLower() == "y")
{
    Console.Write("Enter new registration fee: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal newFee))
    {
        Vehicle.UpdateRegistrationFee(newFee);
        Console.WriteLine("\nAll vehicles now have the new registration fee!");
    }
}

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

// LEVEL 2 - ACCESS MODIFIERS

// PROBLEM 10: University Management System
Console.WriteLine("--- Problem 10: University Management System ---");
Console.WriteLine("Learn about access modifiers and inheritance\n");

Console.WriteLine("--- Create an Undergraduate Student ---");
Console.Write("Enter roll number: ");
if (!int.TryParse(Console.ReadLine(), out int rollNum))
    rollNum = 0;

Console.Write("Enter student name: ");
string studentName = Console.ReadLine() ?? "Unknown";

Console.Write("Enter CGPA (0-4.0): ");
if (!decimal.TryParse(Console.ReadLine(), out decimal studentCGPA))
    studentCGPA = 0m;

Student student = new Student(rollNum, studentName, studentCGPA);
student.DisplayInfo();

Console.Write("\nUpdate CGPA? (y/n): ");
if (Console.ReadLine()?.ToLower() == "y")
{
    Console.Write("Enter new CGPA: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal newCGPA))
    {
        student.SetCGPA(newCGPA);
    }
}

Console.WriteLine("\n--- Create a Postgraduate Student ---");
Console.Write("Enter roll number: ");
if (!int.TryParse(Console.ReadLine(), out int pgRoll))
    pgRoll = 0;

Console.Write("Enter student name: ");
string pgName = Console.ReadLine() ?? "Unknown";

Console.Write("Enter CGPA (0-4.0): ");
if (!decimal.TryParse(Console.ReadLine(), out decimal pgCGPA))
    pgCGPA = 0m;

Console.Write("Enter specialization: ");
string specialization = Console.ReadLine() ?? "General";

PostgraduateStudent pgStudent = new PostgraduateStudent(pgRoll, pgName, pgCGPA, specialization);
pgStudent.DisplayPostgradInfo();

Console.WriteLine("\nNote: Postgraduate class can access protected 'name' member from Student class!");

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

/*
// PROBLEM 11: Book Library System (With Access Modifiers)
Console.WriteLine("--- Problem 11: Book Library System (With Access Modifiers) ---");
Console.WriteLine("Learn about public, protected, and private members\n");

Console.WriteLine("--- Create a Library Book ---");
Console.Write("Enter ISBN: ");
string isbn = Console.ReadLine() ?? "000-0-000000-0";

Console.Write("Enter title: ");
string bookTitle = Console.ReadLine() ?? "Unknown";

Console.Write("Enter author: ");
string bookAuthor = Console.ReadLine() ?? "Unknown";

LibraryBookWithModifiers book = new LibraryBookWithModifiers(isbn, bookTitle, bookAuthor);
book.DisplayInfo();

Console.Write("\nUpdate author? (y/n): ");
if (Console.ReadLine()?.ToLower() == "y")
{
    Console.Write("Enter new author name: ");
    string newAuthor = Console.ReadLine() ?? "Unknown";
    book.SetAuthor(newAuthor);
}

Console.WriteLine("\n--- Create an EBook (inherits from LibraryBook) ---");
Console.Write("Enter eBook ISBN: ");
string ebookISBN = Console.ReadLine() ?? "000-0-000000-0";

Console.Write("Enter eBook title: ");
string ebookTitle = Console.ReadLine() ?? "Unknown";

Console.Write("Enter eBook author: ");
string ebookAuthor = Console.ReadLine() ?? "Unknown";

Console.Write("Enter file format (PDF/EPUB/MOBI): ");
string format = Console.ReadLine() ?? "PDF";

EBook eBook = new EBook(ebookISBN, ebookTitle, ebookAuthor, format);
eBook.DisplayEBookInfo();

Console.WriteLine("\nNote: EBook can access public ISBN and protected Title from LibraryBook!");

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

/*
// PROBLEM 12: Bank Account Management
Console.WriteLine("--- Problem 12: Bank Account Management ---");
Console.WriteLine("Learn about encapsulation with getters and setters\n");

Console.WriteLine("--- Create a Bank Account ---");
Console.Write("Enter account number: ");
string accountNumber = Console.ReadLine() ?? "000000";

Console.Write("Enter account holder name: ");
string accountHolder = Console.ReadLine() ?? "Unknown";

Console.Write("Enter initial balance: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal initialBalance))
    initialBalance = 0m;

BankAccount account = new BankAccount(accountNumber, accountHolder, initialBalance);
account.DisplayInfo();

bool continueBankingTransaction = true;

while (continueBankingTransaction)
{
    Console.WriteLine("\n--- What would you like to do? ---");
    Console.WriteLine("1. Deposit money");
    Console.WriteLine("2. Withdraw money");
    Console.WriteLine("3. View balance");
    Console.WriteLine("4. Exit banking");
    Console.Write("\nEnter your choice (1-4): ");

    string bankChoice = Console.ReadLine() ?? "4";

    if (bankChoice == "1")
    {
        Console.Write("Enter deposit amount: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
        {
            account.Deposit(depositAmount);
        }
    }
    else if (bankChoice == "2")
    {
        Console.Write("Enter withdrawal amount: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
        {
            account.Withdraw(withdrawAmount);
        }
    }
    else if (bankChoice == "3")
    {
        account.DisplayInfo();
    }
    else if (bankChoice == "4")
    {
        continueBankingTransaction = false;
    }
}

Console.WriteLine("\n--- Create a Savings Account (inherits from BankAccount) ---");
Console.Write("Enter savings account number: ");
string savingsAccNumber = Console.ReadLine() ?? "000000";

Console.Write("Enter account holder name: ");
string savingsHolder = Console.ReadLine() ?? "Unknown";

Console.Write("Enter initial balance: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal savingsBalance))
    savingsBalance = 0m;

Console.Write("Enter interest rate (%): ");
if (!decimal.TryParse(Console.ReadLine(), out decimal interestRate))
    interestRate = 2.5m;

SavingsAccount savingsAccount = new SavingsAccount(savingsAccNumber, savingsHolder, savingsBalance, interestRate);
savingsAccount.DisplaySavingsInfo();

Console.Write("\nApply interest? (y/n): ");
if (Console.ReadLine()?.ToLower() == "y")
{
    savingsAccount.ApplyInterest();
}

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/

/*
// PROBLEM 13: Employee Records
Console.WriteLine("--- Problem 13: Employee Records ---");
Console.WriteLine("Learn about protected members in inheritance\n");

Console.WriteLine("--- Create an Employee ---");
Console.Write("Enter employee ID: ");
string employeeID = Console.ReadLine() ?? "E000";

Console.Write("Enter department: ");
string employeeDept = Console.ReadLine() ?? "General";

Console.Write("Enter salary: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal employeeSalary))
    employeeSalary = 0m;

Employee employee = new Employee(employeeID, employeeDept, employeeSalary);
employee.DisplayInfo();

Console.Write("\nUpdate salary? (y/n): ");
if (Console.ReadLine()?.ToLower() == "y")
{
    Console.Write("Enter new salary: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal newSalary))
    {
        employee.SetSalary(newSalary);
    }
}

Console.WriteLine("\n--- Create a Manager (inherits from Employee) ---");
Console.Write("Enter manager ID: ");
string managerID = Console.ReadLine() ?? "M000";

Console.Write("Enter manager department: ");
string managerDept = Console.ReadLine() ?? "General";

Console.Write("Enter manager salary: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal managerSalary))
    managerSalary = 0m;

Console.Write("Enter team size: ");
if (!int.TryParse(Console.ReadLine(), out int teamSize))
    teamSize = 0;

Manager manager = new Manager(managerID, managerDept, managerSalary, teamSize);
manager.DisplayManagerInfo();

Console.WriteLine("\nNote: Manager class can access protected 'department' member from Employee class!");

Console.WriteLine("\nPress any key to continue...\n");
Console.ReadKey();
Console.Clear();
*/
