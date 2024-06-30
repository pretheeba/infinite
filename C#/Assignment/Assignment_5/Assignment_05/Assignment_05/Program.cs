using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. BookShelf");
        Console.WriteLine("2. Box Addition");
        Console.WriteLine("3. Employee Details");
        Console.WriteLine("4. Student Details");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                BookShelfExample();
                break;
            case 2:
                BoxAdditionExample();
                break;
            case 3:
                EmployeeDetailsExample();
                break;
            case 4:
                StudentDetailsExample();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.ReadLine();
    }

    public static void BookShelfExample()
    {
        Console.WriteLine("\n-- BookShelf Example --");

        BookShelf shelf = new BookShelf();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nEnter details for book {i + 1}:");
            Console.Write("Book Name: ");
            string bookName = Console.ReadLine();
            Console.Write("Author Name: ");
            string authorName = Console.ReadLine();

            shelf[i] = new Books(bookName, authorName);
        }

        Console.WriteLine("\nBooks on the shelf:");
        for (int i = 0; i < 5; i++)
        {
            shelf[i].Display();
        }
    }

    public static void BoxAdditionExample()
    {
        Console.WriteLine("\n-- Box Addition Example --");

        Console.Write("Enter Length for Box 1: ");
        double length1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Breadth for Box 1: ");
        double breadth1 = Convert.ToDouble(Console.ReadLine());
        Box box1 = new Box(length1, breadth1);

        Console.Write("\nEnter Length for Box 2: ");
        double length2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Breadth for Box 2: ");
        double breadth2 = Convert.ToDouble(Console.ReadLine());
        Box box2 = new Box(length2, breadth2);

        Box box3 = Box.Add(box1, box2);

        Console.WriteLine("\nBox 1:");
        box1.Display();

        Console.WriteLine("\nBox 2:");
        box2.Display();

        Console.WriteLine("\nBox 3 (Result of Addition):");
        box3.Display();
    }

    public static void EmployeeDetailsExample()
    {
        Console.WriteLine("\n-- Employee Details Example --");

        Console.Write("Enter Employee ID: ");
        int empId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Employee Name: ");
        string empName = Console.ReadLine();
        Console.Write("Enter Salary: ");
        float salary = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter Wages: ");
        float wages = Convert.ToSingle(Console.ReadLine());

        ParttimeEmployee parttimeEmp = new ParttimeEmployee(empId, empName, salary, wages);

        Console.WriteLine("\nDetails of Part-time Employee:");
        parttimeEmp.Display();
    }

    public static void StudentDetailsExample()
    {
        Console.WriteLine("\n-- Student Details Example --");

        Console.Write("Enter Student ID for Day Scholar: ");
        int studentId1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name for Day Scholar: ");
        string name1 = Console.ReadLine();
        IStudent student1 = new Dayscholar { StudentId = studentId1, Name = name1 };

        Console.Write("\nEnter Student ID for Resident: ");
        int studentId2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name for Resident: ");
        string name2 = Console.ReadLine();
        IStudent student2 = new Resident { StudentId = studentId2, Name = name2 };

        Console.WriteLine("\nDetails of Day Scholar:");
        student1.ShowDetails();

        Console.WriteLine("\nDetails of Resident:");
        student2.ShowDetails();
    }
}

public class Books
{
    public string BookName { get; set; }
    public string AuthorName { get; set; }

    public Books(string bookName, string authorName)
    {
        BookName = bookName;
        AuthorName = authorName;
    }

    public void Display()
    {
        Console.WriteLine($"Book: {BookName}, Author: {AuthorName}");
    }
}

public class BookShelf
{
    private Books[] _books = new Books[5];

    public Books this[int index]
    {
        get
        {
            if (index < 0 || index >= _books.Length)
                throw new IndexOutOfRangeException("Index out of range");

            return _books[index];
        }
        set
        {
            if (index < 0 || index >= _books.Length)
                throw new IndexOutOfRangeException("Index out of range");

            _books[index] = value;
        }
    }
}

public class Box
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Box(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public void Display()
    {
        Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
    }

    public static Box Add(Box box1, Box box2)
    {
        double newLength = box1.Length + box2.Length;
        double newBreadth = box1.Breadth + box2.Breadth;
        return new Box(newLength, newBreadth);
    }
}

public class Employee
{
    public int Empid { get; set; }
    public string Empname { get; set; }
    public float Salary { get; set; }

    public Employee(int empid, string empname, float salary)
    {
        Empid = empid;
        Empname = empname;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"Employee ID: {Empid}");
        Console.WriteLine($"Employee Name: {Empname}");
        Console.WriteLine($"Salary: {Salary}");
    }
}

public class ParttimeEmployee : Employee
{
    public float Wages { get; set; }

    public ParttimeEmployee(int empid, string empname, float salary, float wages)
        : base(empid, empname, salary)
    {
        Wages = wages;
    }

    public new void Display()
    {
        base.Display();
        Console.WriteLine($"Wages: {Wages}");
    }
}


public interface IStudent
{

    int StudentId { get; set; }
    string Name { get; set; }

    void ShowDetails();
}

public class Dayscholar : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Type: Day Scholar");
    }
}

public class Resident : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Type: Resident");
    }
}
