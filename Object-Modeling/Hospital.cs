/*Problem 3: Hospital, Doctors, and Patients (Association and Communication)
Description: Model a Hospital where Doctor and Patient objects interact through
consultations. A doctor can see multiple patients, and each patient can consult multiple
doctors.
Tasks:
 Define a Hospital class containing Doctor and Patient classes.
 Create a method Consult() in the Doctor class to show communication, which would
display the consultation between a doctor and a patient.
 Model an association between doctors and patients to show that doctors and
patients can have multiple relationships.
Goal: Practice creating an association with communication between objects by modeling
doctor-patient consultations.*/using System;internal class Hospital{    private string Name;    // Constructor    public Hospital(string name)    {        Name = name;    }    public void AdmitPatient(Doctor doctor, Patient patient)    {        Console.WriteLine($"Hospital {Name} admits Patient {patient.Name} to Doctor {doctor.Name}");        doctor.Consult(patient);    }    }
// Define the Doctor class
internal class Doctor
{
    public string Name { get; private set; }
    // Constructor
    public Doctor(string name)
    {
        Name = name;
    }
    // Method to simulate consultation with a patient
    public void Consult(Patient patient)
    {
        Console.WriteLine($"Doctor {Name} is consulting Patient {patient.Name}");
    }
}
// Define the Patient class
internal class Patient
{
    public string Name { get; private set; }
    // Constructor
    public Patient(string name)
    {
        Name = name;
    }
}


