using System;

public class Student
{
    // Data members/fields
    private int rollNo;
    private string name;
    private string studentClass;
    private string semester;
    private string branch;
    private int[] marks = new int[5];

    // Constructor to initialize the student details
    public Student(int rollNo, string name, string studentClass, string semester, string branch)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.studentClass = studentClass;
        this.semester = semester;
        this.branch = branch;
    }

    // Method to input marks for all 5 subjects
    public void GetMarks()
    {
        Console.WriteLine($"Enter marks for {name} (Roll No: {rollNo}):");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Subject {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }
    }

    // Method to calculate average marks and display result
    public void DisplayResult()
    {
        // Display student details

        // Display marks
        Console.WriteLine("Marks:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Subject {i + 1}: {marks[i]}");
        }


        // Check if all marks are greater than 35
        foreach (int mark in marks)
        {
            if (mark >= 35)
            {
                Console.WriteLine("pass");
                break;
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
        DisplayData();



    }

    // Method to display all student data
    public void DisplayData()
    {
        Console.WriteLine($"\nStudent Name: {name} (Roll No: {rollNo})");
        Console.WriteLine($"Class: {studentClass}, Semester: {semester}, Branch: {branch}");
        Console.ReadLine();
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        // Input variables
        int rollNo;
        string name, studentClass, semester, branch;

        // Get input from user for student details
        Console.WriteLine("Enter Student Roll Number:");
        rollNo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Student Name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter Student Class:");
        studentClass = Console.ReadLine();

        Console.WriteLine("Enter Semester:");
        semester = Console.ReadLine();

        Console.WriteLine("Enter Branch:");
        branch = Console.ReadLine();

        // Create an instance of Student
        Student student = new Student(rollNo, name, studentClass, semester, branch);

        // Input marks
        student.GetMarks();

        // Display result
        student.DisplayResult();
    }
}
