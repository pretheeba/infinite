using System;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Implementing IComparable<T> interface
    public int CompareTo(Person other)
    {
        // Compare persons based on their Age
        return this.Age.CompareTo(other.Age);
    }
}

class Program
{
    static void Main()
    {
        // Comparing integers using CompareTo
        int num1 = 10;
        int num2 = 5;

        Console.WriteLine($"Comparing integers:");
        Console.WriteLine($"num1 = {num1}, num2 = {num2}");

        int resultInt = num1.CompareTo(num2);

        if (resultInt > 0)
        {
            Console.WriteLine($"num1 ({num1}) is greater than num2 ({num2})");
        }
        else if (resultInt < 0)
        {
            Console.WriteLine($"num1 ({num1}) is less than num2 ({num2})");
        }
        else
        {
            Console.WriteLine($"num1 ({num1}) is equal to num2 ({num2})");
        }

        Console.WriteLine();

        // Comparing strings using CompareTo
        string str1 = "apple";
        string str2 = "banana";

        Console.WriteLine($"Comparing strings:");
        Console.WriteLine($"str1 = {str1}, str2 = {str2}");

        int resultStr = str1.CompareTo(str2);

        if (resultStr > 0)
        {
            Console.WriteLine($"str1 ({str1}) comes after str2 ({str2})");
        }
        else if (resultStr < 0)
        {
            Console.WriteLine($"str1 ({str1}) comes before str2 ({str2})");
        }
        else
        {
            Console.WriteLine($"str1 ({str1}) is equal to str2 ({str2})");
        }

        Console.WriteLine();

        // Comparing custom objects using CompareTo
        Person person1 = new Person("Alice", 30);
        Person person2 = new Person("Bob", 25);

        Console.WriteLine($"Comparing persons:");
        Console.WriteLine($"{person1.Name} (Age {person1.Age}) vs {person2.Name} (Age {person2.Age})");

        int resultPerson = person1.CompareTo(person2);

        if (resultPerson < 0)
        {
            Console.WriteLine($"{person1.Name} is younger than {person2.Name}");
        }
        else if (resultPerson > 0)
        {
            Console.WriteLine($"{person1.Name} is older than {person2.Name}");
        }
        else
        {
            Console.WriteLine($"{person1.Name} and {person2.Name} are the same age");
        }
    }
}
