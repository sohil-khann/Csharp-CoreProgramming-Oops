using System;

/*
Sample Program 7: Hospital Management System
Create a Patient class with the following features:
 static:
     A static variable HospitalName shared among all patients.
     A static method GetTotalPatients() to count the total patients admitted.
 this:
     Use this to initialize Name, Age, and Ailment in the constructor.
 readonly:
     Use a readonly variable PatientID to uniquely identify each patient.
 is operator:
     Check if an object is an instance of the Patient class before displaying its details.
*/

namespace Level_01
{
    public class Patient
    {
        public static string HospitalName = "City General Hospital";
        private static int patientCounter = 0;

        public readonly string PatientID;
        public string Name;
        public int Age;
        public string Ailment;

        public Patient(string PatientID, string Name, int Age, string Ailment)
        {
            this.PatientID = PatientID;
            this.Name = Name;
            this.Age = Age;
            this.Ailment = Ailment;
            patientCounter++;
        }

        public static int GetTotalPatients()
        {
            return patientCounter;
        }

        public void DisplayPatientDetails()
        {
            Console.WriteLine("\n--- Patient Admission Record ---");
            Console.WriteLine($"Hospital: {HospitalName}");
            Console.WriteLine($"ID: {this.PatientID}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Ailment: {this.Ailment}");
        }
    }

    public class HospitalManagementSystem
    {
        public static void Run()
        {
            Console.WriteLine($"Welcome to {Patient.HospitalName}");

            Console.Write("Enter Patient ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Patient Age: ");
            int age = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Ailment: ");
            string ailment = Console.ReadLine();

            object record = new Patient(id, name, age, ailment);

            // Using 'is' to verify record type
            if (record is Patient p)
            {
                p.DisplayPatientDetails();
            }
            else
            {
                Console.WriteLine("Error: Invalid patient record object.");
            }

            Console.WriteLine($"Total Patients currently admitted: {Patient.GetTotalPatients()}");
        }
    }
}
