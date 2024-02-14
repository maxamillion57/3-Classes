using System;

// Derived class 2
public class Teacher : Person
{
    // Properties
    public string Subject { get; set; }

    // Constructor
    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    // Method
    public override void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
    }
}
