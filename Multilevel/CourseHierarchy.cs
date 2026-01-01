using System;

namespace MultilevelInheritance
{
    // Superclass Course
    public class Course
    {
        public string CourseName { get; set; }
        public string Duration { get; set; }

        public Course(string courseName, string duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Course: {CourseName}, Duration: {Duration}");
        }
    }

    // Subclass OnlineCourse extending Course
    public class OnlineCourse : Course
    {
        public string Platform { get; set; }
        public bool IsRecorded { get; set; }

        public OnlineCourse(string courseName, string duration, string platform, bool isRecorded) 
            : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Platform: {Platform}, Recorded: {IsRecorded}");
        }
    }

    // Subclass PaidOnlineCourse extending OnlineCourse
    public class PaidOnlineCourse : OnlineCourse
    {
        public decimal Fee { get; set; }
        public decimal Discount { get; set; }

        public PaidOnlineCourse(string courseName, string duration, string platform, bool isRecorded, decimal fee, decimal discount) 
            : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Fee: ${Fee}, Discount: ${Discount}, Final Price: ${Fee - Discount}");
        }
    }
}
