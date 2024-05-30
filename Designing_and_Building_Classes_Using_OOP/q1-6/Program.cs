using System;
using System.Collections.Generic;

// 1. Abstraction: Abstract Person class defines general properties and methods for all person types
public abstract class Person
{
    // 3. Encapsulation: Using properties to protect access to fields
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal Salary { get; set; }
    public List<string> Addresses { get; set; } = new List<string>();

    // Encapsulation: Methods to operate on fields
    public int CalculateAge()
    {
        return DateTime.Now.Year - BirthDate.Year;
    }

    // 5. Polymorphism: Virtual method to be overridden in derived classes
    public virtual decimal CalculateSalary()
    {
        return Salary >= 0 ? Salary : throw new ArgumentException("Salary cannot be negative");
    }

    public void AddAddress(string address)
    {
        Addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return Addresses;
    }
}

// 4. Inheritance: Student class inherits from Person class
public class Student : Person
{
    // Encapsulation: Protecting access to the Courses list
    public List<Course> Courses { get; set; } = new List<Course>();

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public double CalculateGPA()
    {
        double totalPoints = 0;
        int totalCourses = Courses.Count;
        foreach (var course in Courses)
        {
            totalPoints += course.GetGradePoints();
        }
        return totalCourses > 0 ? totalPoints / totalCourses : 0;
    }
}

// 4. Inheritance: Instructor class inherits from Person class
// 5. Polymorphism: Overriding CalculateSalary method to provide specific behavior
public class Instructor : Person
{
    public Department Department { get; set; }
    public DateTime JoinDate { get; set; }

    public override decimal CalculateSalary()
    {
        int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
        decimal bonus = yearsOfExperience * 1000;
        return base.CalculateSalary() + bonus;
    }
}

public class Course
{
    public string Name { get; set; }
    public string Grade { get; set; }

    public double GetGradePoints()
    {
        switch (Grade)
        {
            case "A": return 4.0;
            case "B": return 3.0;
            case "C": return 2.0;
            case "D": return 1.0;
            case "F": return 0.0;
            default: return 0.0;
        }
    }
}

public class Department
{
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();
}

// Interfaces for abstraction
public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    void AddAddress(string address);
    List<string> GetAddresses();
}

public interface IStudentService : IPersonService
{
    void AddCourse(Course course);
    double CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    decimal CalculateSalary();
}

// Main program to demonstrate the use of the classes and principles
public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student
        {
            FirstName = "John",
            LastName = "Doe",
            BirthDate = new DateTime(2000, 1, 1),
            Salary = 0,
            Courses = new List<Course>
            {
                new Course { Name = "Math", Grade = "A" },
                new Course { Name = "Science", Grade = "B" }
            }
        };

        Instructor instructor = new Instructor
        {
            FirstName = "Jane",
            LastName = "Smith",
            BirthDate = new DateTime(1980, 1, 1),
            Salary = 50000,
            JoinDate = new DateTime(2010, 1, 1)
        };

        Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.CalculateAge()}, GPA: {student.CalculateGPA()}");
        Console.WriteLine($"{instructor.FirstName} {instructor.LastName}, Age: {instructor.CalculateAge()}, Salary: {instructor.CalculateSalary()}");
    }
}

