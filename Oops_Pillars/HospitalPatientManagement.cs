using System;
using System.Collections.Generic;

/*
7. Hospital Patient Management
Description: Design a system to manage patients in a hospital.
● Abstract Class:
o Create an abstract class Patient with fields: patientId, name, and age.
o Add an abstract method CalculateBill().
o Implement a concrete method GetPatientDetails().
● Subclasses:
o Extend Patient into InPatient and OutPatient.
o Implement CalculateBill() differently for each subclass.
● Interface:
o Implement an interface IMedicalRecord.
o Define methods AddRecord() and ViewRecords().
● Encapsulation:
o Protect sensitive patient data like diagnosis and medical history.
● Polymorphism:
o Use a Patient reference to handle different patient types dynamically.
o Display billing details based on polymorphic behavior.
*/

namespace Oops_Pillars
{
    // Interface for managing medical records
    public interface IMedicalRecord
    {
        void AddRecord(string recordText);
        void ViewRecords();
    }

    // Abstract class for any patient
    public abstract class Patient
    {
        private string patientId;
        private string name;
        private int age;
        
        // Encapsulated medical history and diagnosis
        protected List<string> history = new List<string>();
        private string currentDiagnosis = "Unknown";

        public string PatientId 
        { 
            get { return patientId; } 
        }
        
        public string Name 
        { 
            get { return name; } 
        }
        
        public int Age 
        { 
            get { return age; } 
        }

        public Patient(string id, string patientName, int patientAge)
        {
            patientId = id;
            name = patientName;
            age = patientAge;
        }

        // Each patient type (In/Out) has a different billing logic
        public abstract double CalculateBill();

        public virtual void GetPatientDetails()
        {
            Console.WriteLine("Patient ID: " + patientId + " | Name: " + name + " | Age: " + age);
        }

        public void SetDiagnosis(string diagnosis)
        {
            currentDiagnosis = diagnosis;
            Console.WriteLine("Diagnosis updated for " + name);
        }

        public string GetDiagnosis()
        {
            return currentDiagnosis;
        }
    }

    // Patients staying in the hospital
    public class InPatient : Patient, IMedicalRecord
    {
        private int daysInHospital;
        private double pricePerDay = 2000;

        public InPatient(string id, string name, int age, int days) 
            : base(id, name, age)
        {
            daysInHospital = days;
        }

        public override double CalculateBill()
        {
            return daysInHospital * pricePerDay;
        }

        public void AddRecord(string recordText)
        {
            history.Add(DateTime.Now.ToShortDateString() + ": " + recordText);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Showing records for " + Name + ":");
            foreach (string entry in history)
            {
                Console.WriteLine(" - " + entry);
            }
        }

        public override void GetPatientDetails()
        {
            base.GetPatientDetails();
            Console.WriteLine("Patient Type: In-Patient | Days: " + daysInHospital + " | Total Bill: " + CalculateBill());
        }
    }

    // Patients visiting for consultation
    public class OutPatient : Patient, IMedicalRecord
    {
        private double fee = 500;

        public OutPatient(string id, string name, int age) 
            : base(id, name, age) { }

        public override double CalculateBill()
        {
            return fee;
        }

        public void AddRecord(string recordText)
        {
            history.Add(DateTime.Now.ToShortDateString() + ": " + recordText);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Records for " + Name + " (Out-Patient):");
            foreach (string entry in history)
            {
                Console.WriteLine(" - " + entry);
            }
        }

        public override void GetPatientDetails()
        {
            base.GetPatientDetails();
            Console.WriteLine("Patient Type: Out-Patient | Consultation Fee: " + CalculateBill());
        }
    }
}
