using MultilevelInheritance;

Console.WriteLine("--- Multilevel Inheritance Sample Problem 1: Order Management ---");
DeliveredOrder order = new DeliveredOrder("ORD123", DateTime.Now.AddDays(-5), "TRK987654", DateTime.Now);
Console.WriteLine($"Order Status: {order.GetOrderStatus()}");

Console.WriteLine("\n--- Multilevel Inheritance Sample Problem 2: Course Hierarchy ---");
PaidOnlineCourse myCourse = new PaidOnlineCourse("C# Masterclass", "20 Hours", "Udemy", true, 99.99m, 20.00m);
myCourse.DisplayDetails();

