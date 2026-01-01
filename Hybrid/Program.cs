using HybridInheritance;

Console.WriteLine("--- Hybrid Inheritance Sample Problem 1: Restaurant Management ---");
Chef chef = new Chef("Mario", "C001");
chef.DisplayInfo();
chef.PerformDuties();

Console.WriteLine();

Waiter waiter = new Waiter("Luigi", "W001");
waiter.DisplayInfo();
waiter.PerformDuties();

Console.WriteLine("\n--- Hybrid Inheritance Sample Problem 2: Vehicle Management ---");
ElectricVehicle tesla = new ElectricVehicle(250, "Tesla Model S");
tesla.DisplayDetails();
tesla.Charge();

Console.WriteLine();

PetrolVehicle mustang = new PetrolVehicle(300, "Ford Mustang");
mustang.DisplayDetails();
mustang.Refuel();

