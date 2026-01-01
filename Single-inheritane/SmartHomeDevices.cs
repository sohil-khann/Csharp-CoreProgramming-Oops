using System;

namespace SingleInheritance
{
    // Superclass Device
    public class Device
    {
        public string DeviceId { get; set; }
        public string Status { get; set; }

        public Device(string deviceId, string status)
        {
            DeviceId = deviceId;
            Status = status;
        }
    }

    // Subclass Thermostat extending Device
    public class Thermostat : Device
    {
        public double TemperatureSetting { get; set; }

        public Thermostat(string deviceId, string status, double temperatureSetting) 
            : base(deviceId, status)
        {
            TemperatureSetting = temperatureSetting;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {DeviceId}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
        }
    }
}
