/*Problem 1: School and Students with Courses (Association and Aggregation)
Description: Model a School with multiple Student objects, where each student can enroll in
multiple courses, and each course can have multiple students.
Tasks:
 Define School, Student, and Course classes.
 Model an association between Student and Course to show that students can enroll
in multiple courses.
 Model an aggregation relationship between School and Student.
 Demonstrate how a student can view the courses they are enrolled in and how a
course can show its enrolled students.
Goal: Practice association by modeling many-to-many relationships between students and
courses.*/using System;using System.Collections.Generic;
// Define the School class
internal class School
{
    private string Name;
    private List<Student> students;
    // Constructor
    public School(string name)
    {
        Name = name;
        students = new List<Student>();
    }
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
}
// Define the Student class
internal class Student
{
    public string Name { get; private set; }
    private List<Course> courses;
    // Constructor
    public Student(string name)
    {
        Name = name;
        courses = new List<Course>();
    }
    public void EnrollInCourse(Course course)
    {
        courses.Add(course);
        course.AddStudent(this);
    }
    // Method to display all courses the student is enrolled in
    public void DisplayCourses()
    {
        Console.WriteLine($"Courses enrolled by {Name}:");
        foreach (var course in courses)
        {
            Console.WriteLine($"- {course.Title}");
        }
    }
}
// Define the Course class
internal class Course
{
    public string Title { get; private set; }
    private List<Student> students;
    // Constructor
    public Course(string title)
    {
        Title = title;
        students = new List<Student>();
    }
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    // Method to display all students enrolled in the course
    public void DisplayStudents()
    {
        Console.WriteLine($"Students enrolled in {Title}:");
        foreach (var student in students)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}