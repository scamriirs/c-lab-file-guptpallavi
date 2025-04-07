using System;
using System.Collections.Generic;

class Student
{
    public int RegistrationNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Class { get; set; }
    public string Address { get; set; }

    public override string ToString()
    {
        return $"RegNo: {RegistrationNumber}, Name: {Name}, Age: {Age}, Class: {Class}, Address: {Address}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list of students
        List<Student> students = new List<Student>
        {
            new Student { RegistrationNumber = 1, Name = "Alice", Age = 14, Class = "8th", Address = "123 Street A" },
            new Student { RegistrationNumber = 2, Name = "Bob", Age = 15, Class = "9th", Address = "456 Street B" },
            new Student { RegistrationNumber = 3, Name = "Charlie", Age = 14, Class = "8th", Address = "789 Street C" },
            new Student { RegistrationNumber = 4, Name = "David", Age = 16, Class = "10th", Address = "101 Street D" },
            new Student { RegistrationNumber = 5, Name = "Eve", Age = 15, Class = "9th", Address = "202 Street E" },
            new Student { RegistrationNumber = 6, Name = "Frank", Age = 14, Class = "8th", Address = "303 Street F" },
            new Student { RegistrationNumber = 7, Name = "Grace", Age = 16, Class = "10th", Address = "404 Street G" },
            new Student { RegistrationNumber = 8, Name = "Hannah", Age = 15, Class = "9th", Address = "505 Street H" },
            new Student { RegistrationNumber = 9, Name = "Ivy", Age = 14, Class = "8th", Address = "606 Street I" },
            new Student { RegistrationNumber = 10, Name = "Jack", Age = 16, Class = "10th", Address = "707 Street J" }
        };

        // Display the student details
        Console.WriteLine("Student Database:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
