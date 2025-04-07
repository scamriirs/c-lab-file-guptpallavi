using System;

class Student
{
    public string Name;
    public int Age;

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Name = "John";
        student.Age = 21;
        student.DisplayDetails();
    }
}
