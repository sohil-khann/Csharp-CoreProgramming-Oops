using System;

namespace HybridInheritance
{
    // Superclass Person
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Person(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}");
        }
    }

    // Interface Worker
    public interface IWorker
    {
        void PerformDuties();
    }

    // Subclass Chef
    public class Chef : Person, IWorker
    {
        public Chef(string name, string id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is cooking delicious meals.");
        }
    }

    // Subclass Waiter
    public class Waiter : Person, IWorker
    {
        public Waiter(string name, string id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is serving customers and taking orders.");
        }
    }
}
