using System;

// Derived class 1
public class Student : Person
{
    // Properties
    public string School { get; set; }

    // Constructor
    public Student(string name, int age, string school) : base(name, age)
    {
        School = school;
    }

    // Method
    public override void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, School: {School}");
    }
}
