# 🌉 BridgeLabz Training Program - Core Programming

Welcome to the official repository for **BridgeLabz .NET Fullstack Training**. This repository documents a comprehensive learning journey through Core C# programming fundamentals, structured across three progressive difficulty levels.

>  **Status**: Active Development  
>  **Target Framework**: .NET 10.0  
>  **IDE**: Visual Studio 2022+  
>  Author: : Sohil khan

---

##  Repository Structure

This repository is organized into three progressive levels, each building upon fundamental programming concepts:

```
Csharp-CoreProgramming-Oops/
├── Readme.md          # Project overview and structure
└── .gitignore         # Git ignore configuration
```

```
## Branch Structure
CoreProgramming/
├── class-and-objects
├── constructors 
├── keywords-and-operator          
├── inheritance
├── diagrams
```
```
##  structure of control-/
Csharp-CoreProgramming-Oops/class-and-objects
├── Level_01/          # Fundamental Oops Concepts

=======
```
```
inheritance/
├── Single-inheritane/   # Single Inheritance Problems
├── Multilevel/          # Multilevel Inheritance Problems
├── Hierarchical/        # Hierarchical Inheritance Problems
├── Hybrid/              # Hybrid Inheritance (Interfaces) Problems
├── Readme.md            # Project overview and structure
└── .gitignore           # Git ignore configuration
```

```
diagrams/
├── class-and-objects/   # Class and Objects
├── Object-modeling/          # Object Modeling
├── Readme.md            # Project overview and structure
└── .gitignore           # Git ignore configuration
```
```
constructors/
 Level_01/               # Fundamental Oops Concepts (Level 01)
    BankAccount.cs
    LibraryBook.cs
    Employee.cs
    Student.cs
    Cirlce.cs
    CarRental.cs
    Course.cs
    Person.cs
    Product.cs
    Vehicle.cs
    Program.cs
    HotelBooking.cs
    LibraryBookModifiers.cs
 Readme.md               # Project overview and structure
 .gitignore              # Git ignore configuration

```
 
```
 keywords-and-operator /
 Level_01/               # Fundamental Oops Concepts (Level 01)
    BankAccountSystem.cs
    LibraryManagementSystem.cs
    EmployeeManagementSystem.cs
    ShoppingCartSystem.cs
    StudentManagementSystem.cs
    VehicleRegistrationSystem.cs
    HospitalManagementSystem.cs
    Program.cs
 Readme.md               # Project overview and structure
 .gitignore              # Git ignore configuration
```



## Inheritance Categories

### 1. Single Inheritance
- **Library Management**: `Book` (Superclass) and `Author` (Subclass).
- **Smart Home Devices**: `Device` (Superclass) and `Thermostat` (Subclass).

### 2. Multilevel Inheritance
- **Order Management**: `Order` → `ShippedOrder` → `DeliveredOrder`.
- **Course Hierarchy**: `Course` → `OnlineCourse` → `PaidOnlineCourse`.

### 3. Hierarchical Inheritance
- **Bank Account Types**: `BankAccount` (Base) with `SavingsAccount`, `CheckingAccount`, and `FixedDepositAccount` (Subclasses).
- **School System**: `Person` (Superclass) with `Teacher`, `Student`, and `Staff` (Subclasses).

### 4. Hybrid Inheritance
- **Smart Device Control**: `ElectronicDevice` and `IConnectivity` implemented by `SmartPhone`.

## 🏛️ OOP Pillars (Oops_Pillars)

This project demonstrates the core pillars of Object-Oriented Programming: **Abstraction, Encapsulation, Inheritance, and Polymorphism** through 8 real-world scenarios.

### 1. Employee Management System
- **Concepts**: Abstract class `Employee`, Interface `IDepartment`.
- **Implementation**: Manages Full-Time and Part-Time employees with dynamic salary calculation and department assignment.

### 2. E-Commerce Platform
- **Concepts**: Abstraction, Interface `ITaxable`.
- **Implementation**: Calculates discounts and taxes for various product categories like Electronics, Clothing, and Groceries.

### 3. Vehicle Rental System
- **Concepts**: Abstract class `Vehicle`, Interface `IInsurable`.
- **Implementation**: Handles rental costs and insurance calculations for Cars, Bikes, and Trucks.

### 4. Banking System
- **Concepts**: Encapsulation, Abstract class `BankAccount`, Interface `ILoanable`.
- **Implementation**: Securely manages Savings and Current accounts with interest calculation and loan eligibility checks.

### 5. Library Management System
- **Concepts**: Abstraction, Interface `IReservable`.
- **Implementation**: Manages Books, Magazines, and DVDs with specific loan durations and reservation capabilities.

### 6. Online Food Delivery System
- **Concepts**: Polymorphism, Interface `IDiscountable`.
- **Implementation**: Processes Veg and Non-Veg food items with handling charges and dynamic discounts.

### 7. Hospital Patient Management
- **Concepts**: Encapsulation of sensitive medical data, Interface `IMedicalRecord`.
- **Implementation**: Tracks In-Patients and Out-Patients with billing logic and secure medical history management.

### 8. Ride-Hailing Application
- **Concepts**: Abstract class `RideVehicle`, Interface `IGPS`.
- **Implementation**: Calculates ride fares for Cars, Bikes, and Autos with real-time location updates via GPS.

---



##  Technology Stack

- **C# 12** - Modern .NET with latest language features
- **.NET 10.0** - Latest framework with enhanced performance
- **Visual Studio 2022+** - Professional development environment
- **Git & GitHub** - Version control and collaboration
- **Nullable Reference Types** - Modern C# safety features
- **Implicit Usings** - Clean code practices

---


##  Learning Progression
###  Level 01 - Class and Objects
Object-oriented fundamentals: classes, objects, methods, and properties
- Creating classes and instantiating objects
- Defining fields, properties, constructors, and methods
- Encapsulation and access modifiers (public, private)
- Object interaction and method invocation

---

##  Code Quality Standards

### Architecture Patterns
- **Static Classes**: Organized problem-solving utilities
- **Consistent Naming**: Clear, descriptive method and variable names
- **Separation of Concerns**: Each problem in its own dedicated file
- **Modular Design**: Independent, reusable problem solutions

### Best Practices Implemented
- **Input Validation**: Comprehensive error handling with `TryParse`
- **User Experience**: Clear prompts and formatted output
- **Code Organization**: Logical file structure and naming conventions
- **Performance Optimization**: Efficient algorithms (O(√n) for prime checking)
- **Modern C# Features**: Nullable reference types, implicit usings, string interpolation

### Error Handling Strategy
- **Graceful Degradation**: Programs continue execution despite invalid input
- **User-Friendly Messages**: Clear error descriptions and retry guidance
- **Edge Case Handling**: Comprehensive boundary condition testing

---

##  Getting Started

### Prerequisites
- **.NET 10.0 SDK** 
- **Visual Studio 2022** or **Visual Studio Code** with C# extension
- **Git** for version control

### Running the Programs

1. **Clone the repository**:
   ```bash
   git clone <repository-url>
   cd CoreProgramming
   ```

2. **Navigate to any Branch**:
   ```bash
   git switch branch-name
   ```

3. **Run a specific level**:
   ```bash
   dotnet run
   ```


---

## Project Statistics

- **Total Problems**: 30+ programming exercises
- **Lines of Code**: 1000+ lines of well-documented C# code
- **Concepts Covered**: Basic syntax, control flow, loops, mathematical algorithms, number theory
- **Difficulty Progression**: Beginner → Intermediate → Advanced
- **Framework**: Modern .NET 10.0 with latest C# features

---

##  Learning Objectives Achieved

 **Core Programming Fundamentals** - Variables, data types, operators  
 **Control Structures** - Conditional statements, loops, branching  
 **Input/Output Operations** - Console interaction, parsing, validation  
 **Mathematical Programming** - Algorithms, number theory, sequences  
 **Problem-Solving Skills** - Algorithmic thinking, optimization  
 **Code Organization** - Modular design, naming conventions  
 **Error Handling** - Validation, user experience  
 **Modern C# Practices** - Latest language features, safety mechanisms  

---

##  Future Enhancements

- **Object-Oriented Programming** - Classes, inheritance, polymorphism
- **Data Structures** - Arrays, lists, dictionaries, custom collections
- **Advanced Algorithms** - Sorting, searching, recursion
- **File I/O** - Persistent data storage and retrieval
- **Unit Testing** - Comprehensive test coverage with xUnit/NUnit
- **GUI Applications** - Windows Forms or WPF implementations

---

##  Support & Contributing

This is a personal learning repository documenting progress through BridgeLabz training program. The code represents foundational programming concepts and serves as a reference for C# beginners and intermediate developers.

**Note**: This repository is actively maintained as part of ongoing professional development in .NET fullstack technologies.

---

*Last Updated: December 2025*  

Author: Sohil khan

