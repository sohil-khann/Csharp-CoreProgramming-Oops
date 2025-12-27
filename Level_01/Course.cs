/*
 * LEVEL 2 PRACTICE - PROBLEM 2: Online Course Management
 * Design a Course class with:
 * - Instance Variables: courseName, duration, fee.
 * - Class Variable: instituteName (common for all courses).
 * Implement the following methods:
 * - An instance method DisplayCourseDetails() to display course details.
 * - A class method UpdateInstituteName() to modify the institute name for all courses.
 */

namespace PracticePrograms
{
    public class Course

        //instance variables
        public string CourseName { get; set; }
        public int Duration { get; set; }
        public decimal Fee { get; set; }
        private static string instituteName = "Tech Academy";


    //        //parameterized constructor
    public Course(string courseName, int duration, decimal fee)
        {
            CourseName = courseName;
            Duration = duration;
            Fee = fee;
        }

    //instance method to display course details
    public void DisplayCourseDetails()
        {
            Console.WriteLine($"Course: {CourseName}, Duration: {Duration} hours, Fee: ${Fee}, Institute: {instituteName}");
        }

    //class method to update institute name
    public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
            Console.WriteLine($"Institute name updated to: {instituteName}");
        }
    //class method to get institute name
    public static string GetInstituteName()
        {
            return instituteName;
        }
    }
}
