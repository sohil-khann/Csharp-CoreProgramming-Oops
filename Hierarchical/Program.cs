using HierarchicalInheritance;

Console.WriteLine("--- Hierarchical Inheritance Sample Problem 1: Bank Account Types ---");
SavingsAccount savings = new SavingsAccount("SAV001", 5000.00m, 3.5);
savings.DisplayAccountType();
Console.WriteLine();
CheckingAccount checking = new CheckingAccount("CHK001", 2000.00m, 500.00m);
checking.DisplayAccountType();
Console.WriteLine();
FixedDepositAccount fd = new FixedDepositAccount("FD001", 10000.00m, 12);
fd.DisplayAccountType();

Console.WriteLine("\n--- Hierarchical Inheritance Sample Problem 2: School System ---");
Teacher teacher = new Teacher("Mr. Smith", 40, "Mathematics");
teacher.DisplayRole();
Console.WriteLine();
Student student = new Student("Alice", 15, "10th Grade");
student.DisplayRole();
Console.WriteLine();
Staff staff = new Staff("Bob", 35, "Administration");
staff.DisplayRole();

