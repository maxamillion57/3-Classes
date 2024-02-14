using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating objects of derived classes
        Student student = new Student("Alice", 20, "XYZ School");
        Teacher teacher = new Teacher("Bob", 35, "Math");

        // Calling methods
        Console.WriteLine("Student Details:");
        student.DisplayDetails();

        Console.WriteLine("\nTeacher Details:");
        teacher.DisplayDetails();
    }
}
