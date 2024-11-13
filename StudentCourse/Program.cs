using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }

    public Student(string name, int id, string major, double gpa)
    {
        Name = name;
        ID = id;
        Major = major;
        GPA = (gpa >= 0.0 && gpa <= 4.0) ? gpa : 0.0;
    }
}

public class Course
{
    public string CourseCode { get; set; }
    public string Title { get; set; }
    public string Instructor { get; set; }
    public int Credits { get; set; }

    public Course(string courseCode, string title, string instructor, int credits)
    {
        CourseCode = courseCode;
        Title = title;
        Instructor = instructor;
        Credits = credits;
    }
}

public class Program
{
    private List<Course> _courses = new List<Course>();

    public void AddCourse(Course course)
    {
        _courses.Add(course);
        Console.WriteLine($"Course {course.Title} added.");
    }

    public void RemoveCourse(string courseCode)
    {
        var course = _courses.Find(c => c.CourseCode == courseCode);
        if (course != null)
        {
            _courses.Remove(course);
            Console.WriteLine($"Course {course.Title} removed.");
        }
        else
        {
            Console.WriteLine("Course not found.");
        }
    }

    public void DisplayAllCourses()
    {
        if (_courses.Count == 0)
        {
            Console.WriteLine("No courses available.");
        }
        else
        {
            foreach (var course in _courses)
            {
                Console.WriteLine($"Code: {course.CourseCode}, Title: {course.Title}, Instructor: {course.Instructor}, Credits: {course.Credits}");
            }
        }
    }

    public static void Main(string[] args)
    {
        Program program = new Program();

        Course course1 = new Course("CSC100", "Python I", "Dr. Ramsay", 20);
        Course course2 = new Course("CSC101", "Java ", "Dr. Gordon", 30);
        Course course3 = new Course("CSC102", "C++", "Kushal", 27);

        program.AddCourse(course1);
        program.AddCourse(course2);
        program.AddCourse(course3);

        program.DisplayAllCourses();

        program.RemoveCourse("CSC102");

        program.DisplayAllCourses();
    }
}