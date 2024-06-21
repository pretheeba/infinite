using System;

public enum Season { Spring, Summer, Autumn, Winter };

public class Program
{
    public static void Main()
    {
        // Value type comparisons
        int number1 = 10;
        int number2 = 10;
        Console.WriteLine($"number1 == number2 : {number1 == number2}"); // true
        Console.WriteLine($"number1.Equals(number2) : {number1.Equals(number2)}"); // true
        Console.WriteLine("--------------------");

        // Enum comparisons
        Season season1 = Season.Summer;
        Season season2 = Season.Summer;
        Console.WriteLine($"season1 == season2 : {season1 == season2}"); // true
        Console.WriteLine($"season1.Equals(season2) : {season1.Equals(season2)}"); // true
        Console.WriteLine("--------------------");

        // Reference type (string) comparisons
        string str1 = "hello";
        string str2 = "hello";
        Console.WriteLine($"str1 == str2 : {str1 == str2}"); // true
        Console.WriteLine($"str1.Equals(str2) : {str1.Equals(str2)}"); // true
        Console.WriteLine("--------------------");

        // Case-insensitive string comparison
        string name1 = "Pretheeba";
        string name2 = "pretheeba";
        Console.WriteLine($"name1.Equals(name2, StringComparison.OrdinalIgnoreCase) : {name1.Equals(name2, StringComparison.OrdinalIgnoreCase)}"); // true
    }
}
